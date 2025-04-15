// Kết nối và xử lý thông báo tin nhắn chat
document.addEventListener('DOMContentLoaded', function() {
    // Khởi tạo kết nối SignalR
    const connection = new signalR.HubConnectionBuilder()
        .withUrl("/userChatHub")
        .withAutomaticReconnect()
        .build();
        
    // Tìm badge thông báo tin nhắn
    const badges = document.querySelectorAll('.chat-notification-badge');
    if (badges.length === 0) return;
    
    // Lấy ID người dùng từ URL hoặc từ phần tử ẩn
    let currentUserId = '';
    const urlParams = new URLSearchParams(window.location.search);
    if (urlParams.has('userId')) {
        currentUserId = urlParams.get('userId');
    } else {
        // Lấy từ session trong JavaScript
        const sessionUserId = sessionStorage.getItem('userId');
        if (sessionUserId) {
            currentUserId = sessionUserId;
        }
    }
    
    if (!currentUserId) {
        // Thử lấy từ thẻ input ẩn nếu có
        const userIdInputs = document.querySelectorAll('input[name="userId"], input[id*="userId"], input[id*="UserId"]');
        for (const input of userIdInputs) {
            if (input.value) {
                currentUserId = input.value;
                break;
            }
        }
    }
    
    // Nếu vẫn không tìm thấy userId, thử lấy từ cookie
    if (!currentUserId) {
        const cookies = document.cookie.split(';');
        for (const cookie of cookies) {
            const [name, value] = cookie.trim().split('=');
            if (name === 'userId' || name === 'UserId') {
                currentUserId = value;
                break;
            }
        }
    }
    
    // Khi nhận được tin nhắn mới
    connection.on("ReceiveMessage", function (message) {
        // Chỉ xử lý tin nhắn đến cho người dùng hiện tại
        if (message.receiverId == currentUserId) {
            updateUnreadCount(1);
        }
    });
    
    // Khi tin nhắn được đánh dấu là đã đọc
    connection.on("MessagesRead", function (userId) {
        // Có thể cập nhật lại số lượng tin nhắn chưa đọc nếu cần
        refreshUnreadCount();
    });
    
    // Bắt đầu kết nối
    connection.start().then(function () {
        console.log("Kết nối SignalR cho thông báo chat thành công!");
        
        if (currentUserId) {
            // Tham gia nhóm người dùng
            connection.invoke("JoinUserGroup", currentUserId);
            
            // Lưu userId vào sessionStorage để sử dụng sau này
            sessionStorage.setItem('userId', currentUserId);
            
            // Cập nhật số lượng tin nhắn chưa đọc ban đầu
            refreshUnreadCount();
        } else {
            // Nếu không tìm thấy userId, thử lấy từ server
            fetch('/Chat/GetCurrentUserId')
                .then(response => response.json())
                .then(data => {
                    if (data && data.userId) {
                        currentUserId = data.userId;
                        sessionStorage.setItem('userId', currentUserId);
                        connection.invoke("JoinUserGroup", currentUserId);
                        refreshUnreadCount();
                    }
                })
                .catch(error => console.error('Lỗi khi lấy userId:', error));
        }
    }).catch(function (err) {
        console.error("Lỗi kết nối SignalR: " + err.toString());
    });
    
    // Xử lý khi rời khỏi trang
    window.addEventListener("beforeunload", function () {
        if (currentUserId) {
            connection.invoke("LeaveUserGroup", currentUserId);
        }
    });
    
    // Hàm cập nhật số lượng tin nhắn chưa đọc
    function updateUnreadCount(increment) {
        badges.forEach(badge => {
            let count = parseInt(badge.textContent) || 0;
            count += increment;
            
            badge.textContent = count > 99 ? '99+' : count;
            badge.style.display = count > 0 ? '' : 'none';
        });
    }
    
    // Hàm làm mới số lượng tin nhắn chưa đọc từ server
    function refreshUnreadCount() {
        fetch('/Chat/GetUnreadCount')
            .then(response => response.json())
            .then(data => {
                badges.forEach(badge => {
                    badge.textContent = data > 99 ? '99+' : data;
                    badge.style.display = data > 0 ? '' : 'none';
                });
            })
            .catch(error => console.error('Lỗi khi lấy số tin nhắn chưa đọc:', error));
    }
});
