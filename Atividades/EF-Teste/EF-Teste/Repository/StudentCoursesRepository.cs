using EF_Teste.Data;
using EF_Teste.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;

namespace EF_Teste.Repository
{
    public class StudentCoursesRepository : IStudentCoursesRepository
    {
        private readonly SchoolContext _schoolContext;

        public StudentCoursesRepository(SchoolContext schoolContext)
        {
            this._schoolContext = schoolContext;
        }

        public async Task Create(StudentCourses studentCourses)
        {
            await _schoolContext.SaveChangesAsync();
            await _schoolContext.StudentCourses.AddAsync(studentCourses);
        }

        public async Task Delete(StudentCourses studentCourses)
        {
            _schoolContext.Remove(studentCourses);
            await _schoolContext.SaveChangesAsync();
        }

        public async Task<List<StudentCourses>> Get(int studentId, int courseId)
        {
            var data = await _schoolContext.StudentCourses
                .Include(x => x.Course)
                .Include(x => x.Student)
                .Include(w => w.StudentID == studentId && w.CourseID == courseId)
                .FirstOrDefaultAsync();

            return data;
        }

        public async Task<List<StudentCourses>> GetAll()
        {
            var data = await _schoolContext.StudentCourses
                .Include(x => x.Course)
                .Include(x => x.Student)
                .ToListAsync();

            return data;
        }

        public async Task<List<StudentCourses>> GetByCourseId(string name)
        {
            var data = await _schoolContext.StudentCourses
                .Include(x => x.Course)
                .Include(x => x.Student)
                .Where(w => w.Course!.Name!.ToLower().Contains(name.ToLower()))
                .ToListAsync();

            return data;
        }

        public async Task<List<StudentCourses>> GetByCourseName(string name)
        {
            var data = await _schoolContext.StudentCourses
                .Include(x => x.Course)
                .Include(x => x.Student)
                .Where(w => w.Course!.Name!.ToLower().Contains(name.ToLower()))
                .ToListAsync();

            return data;
        }

        public Task<StudentCourses> GetByStudentCoursesId(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<StudentCourses>> GetByStudentName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(StudentCourses studentCourses)
        {
            throw new NotImplementedException();
        }
    }
}
