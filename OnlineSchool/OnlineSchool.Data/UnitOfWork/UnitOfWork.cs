using OnlineSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool.Data.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private Context context = new Context();

        private IGenericRepository<School> schoolRepository;
        private IGenericRepository<Subject> subjectRepository;
        private ClassRepository classRepository;

        public ClassRepository ClassRepository
        {
            get
            {
                if (classRepository == null)
                {
                    this.classRepository = new ClassRepository(context);
                }

                return classRepository;
            }
        }

        public IGenericRepository<School> SchoolRepository
        {
            get
            {
                if (this.schoolRepository == null)
                {
                    this.schoolRepository = new GenericRepository<School>(context);
                }

                return this.schoolRepository;
            }
        }

        public IGenericRepository<Subject> SubjectRepository
        {
            get
            {
                if (this.subjectRepository == null)
                {
                    this.subjectRepository = new GenericRepository<Subject>(context);
                }

                return this.subjectRepository;
            }
        }

        

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {

            GC.SuppressFinalize(this);
        }
    }
}
