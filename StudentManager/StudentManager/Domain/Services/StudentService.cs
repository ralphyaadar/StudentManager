using StudentManager.Models;

namespace StudentManager.Domain.Services;

public class StudentService : IStudentService
{
    private readonly IGenericRepository<Student> _repository;

    public StudentService(IGenericRepository<Student> repository)
    {
        _repository = repository;
    }

    public IEnumerable<Student> GetAllStudents()
    {
        return _repository.GetAll();
    }

    public Student GetStudent(int id)
    {
        return _repository.GetById(id);
    }

    public void DeleteStudent(int id)
    {
        _repository.Remove(id);
    }

    public void AddStudent(Student student)
    {
        _repository.Add(student);
    }
}

public interface IStudentService
{
    IEnumerable<Student> GetAllStudents();

    Student GetStudent(int id);

    void DeleteStudent(int id);

    void AddStudent(Student student);
}