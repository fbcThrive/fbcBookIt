//-----------------------------------------------------------------------------
// <auto-generated> 
// ^^^ Comment out the above line to allow ReSharper to validate the 
//  using clauses.
//	This code was generated from a template.
//
//	Manual changes to this file may cause unexpected behavior in your 
//	application.
//	Manual changes to this file will be overwritten if the code is 
//	regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------

namespace FbcBookIt.DataAccess
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;
	using Entity;
	
	public partial interface IFbcBookItContext: IDisposable
	{
		void DefeatChangeTracking(object aEntity);
	
		IDbSet<TEntity> GetTable<TEntity>() where TEntity: class, new();
	
		int SaveChanges();
	
		Database Database { get; }
		DbContextConfiguration Configuration { get; }
	
		IDbSet<BookLoan> BookLoanDb { get; set; }
		IDbSet<BookRequest> BookRequestDb { get; set; }
		IDbSet<Copy> CopyDb { get; set; }
		IDbSet<CopyStatu> CopyStatuDb { get; set; }
		IDbSet<District> DistrictDb { get; set; }
		IDbSet<FormatType> FormatTypeDb { get; set; }
		IDbSet<LoanStatu> LoanStatuDb { get; set; }
		IDbSet<RequestStatu> RequestStatuDb { get; set; }
		IDbSet<School> SchoolDb { get; set; }
		IDbSet<Student> StudentDb { get; set; }
		IDbSet<StudentTeacherSchool> StudentTeacherSchoolDb { get; set; }
		IDbSet<Teacher> TeacherDb { get; set; }
		IDbSet<Title> TitleDb { get; set; }
	
	}
	
	public partial class FbcBookItContext: DbContext, IFbcBookItContext
	{
		static FbcBookItContext()
		{
			Database.SetInitializer<FbcBookItContext>(null);
		}
	
		public FbcBookItContext()
			: base("Name=DefaultConnection")
		{
			Configuration.LazyLoadingEnabled = false;
		}
	
		partial void CustomOnModelCreating();
	
		protected override void OnModelCreating(DbModelBuilder aModelBuilder)
		{
			CustomOnModelCreating();
			
			aModelBuilder.Configurations.Add(new BookLoanMap());
			aModelBuilder.Configurations.Add(new BookRequestMap());
			aModelBuilder.Configurations.Add(new CopyMap());
			aModelBuilder.Configurations.Add(new CopyStatuMap());
			aModelBuilder.Configurations.Add(new DistrictMap());
			aModelBuilder.Configurations.Add(new FormatTypeMap());
			aModelBuilder.Configurations.Add(new LoanStatuMap());
			aModelBuilder.Configurations.Add(new RequestStatuMap());
			aModelBuilder.Configurations.Add(new SchoolMap());
			aModelBuilder.Configurations.Add(new StudentMap());
			aModelBuilder.Configurations.Add(new StudentTeacherSchoolMap());
			aModelBuilder.Configurations.Add(new TeacherMap());
			aModelBuilder.Configurations.Add(new TitleMap());
		}
	
		public void DefeatChangeTracking(object aEntity)
		{
			Entry(aEntity).State = EntityState.Modified;
		}
	
		public IDbSet<TEntity> GetTable<TEntity>() where TEntity: class, new()
		{
			return Set<TEntity>();
		}
	
		public IDbSet<BookLoan> BookLoanDb { get; set; }
		public IDbSet<BookRequest> BookRequestDb { get; set; }
		public IDbSet<Copy> CopyDb { get; set; }
		public IDbSet<CopyStatu> CopyStatuDb { get; set; }
		public IDbSet<District> DistrictDb { get; set; }
		public IDbSet<FormatType> FormatTypeDb { get; set; }
		public IDbSet<LoanStatu> LoanStatuDb { get; set; }
		public IDbSet<RequestStatu> RequestStatuDb { get; set; }
		public IDbSet<School> SchoolDb { get; set; }
		public IDbSet<Student> StudentDb { get; set; }
		public IDbSet<StudentTeacherSchool> StudentTeacherSchoolDb { get; set; }
		public IDbSet<Teacher> TeacherDb { get; set; }
		public IDbSet<Title> TitleDb { get; set; }
	
	}
}
