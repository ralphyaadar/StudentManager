using StudentManager.Models;

namespace StudentManager.Domain;

/// <summary>
/// DAL repository
/// </summary>
/// <typeparam name="T"></typeparam>
public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly StudentDbContext _context;

    public GenericRepository(StudentDbContext context)
    {
        _context = context;
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);

        _context.SaveChanges();
    }

    public void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);

        _context.SaveChanges();
    }
}

public interface IGenericRepository<T> where T : class
{
    T GetById(int id);

    IEnumerable<T> GetAll();

    void Add(T entity);

    void Remove(T entity);
}