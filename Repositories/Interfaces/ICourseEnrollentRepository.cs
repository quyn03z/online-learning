﻿using Microsoft.EntityFrameworkCore;
using OnlineLearning.Models.Domains.UserCourseRelationship;

namespace OnlineLearning.Repositories.Interfaces
{
	public interface ICourseEnrollentRepository : IBaseRepository<CourseEnrollment>
	{
		Task<bool> CheckUserPurchaseCourseAsync(long? userId, long courseId);
	}
}
