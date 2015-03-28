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

namespace FbcBookIt.Repository
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	//using AWEFramework.AWECmn;
	//using Entity;
	using FbcBookIt.DataAccess;
	using FbcBookIt.Entity;
	
	// Table Name: Student
	public partial interface IStudentR
		: IBASE_RepositoryDbTable
	{
		bool Any();
	
		bool Exists(System.Guid aStudentID);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		Student Find(System.Guid aStudentID);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		Student Get(System.Guid aStudentID);
	
		List<Student> GetAll();
	
		// There are several methods that add a record to a table:
		//	1. Add
		//  2. Insert
		//  3. InsertAndReturnPrimaryKey
		// - Add will add the record if possible and return the entity updated with
		// the primary key information
		// - Insert will add the record if possible and return void.
		// - InsertAndReturnPrimaryKey will add the record if possible and then 
		// return the new primary key (a single value for single primary key
		// tables, an instance of a custom class containing all portions of the 
		// primary key for a table with a compound primary key).
		Student Add(Student aStudent);
	
		// There are several methods that add a record to a table:
		//	1. Add
		//  2. Insert
		//  3. InsertAndReturnPrimaryKey
		// - Add will add the record if possible and return the entity updated with
		// the primary key information
		// - Insert will add the record if possible and return void.
		// - InsertAndReturnPrimaryKey will add the record if possible and then 
		// return the new primary key (a single value for single primary key
		// tables, an instance of a custom class containing all portions of the 
		// primary key for a table with a compound primary key).
		void Insert(Student aStudent);
	
		// There are several methods that add a record to a table:
		//	1. Add
		//  2. Insert
		//  3. InsertAndReturnPrimaryKey
		// - Add will add the record if possible and return the entity updated with
		// the primary key information
		// - Insert will add the record if possible and return void.
		// - InsertAndReturnPrimaryKey will add the record if possible and then 
		// return the new primary key (a single value for single primary key
		// tables, an instance of a custom class containing all portions of the 
		// primary key for a table with a compound primary key).
		System.Guid InsertAndReturnPrimaryKey(Student aStudent);
	
		void Update(Student aStudent);
	
		void Delete(System.Guid aStudentID);
	
		bool IsActive(System.Guid aStudentID);
	
		void Remove(System.Guid aStudentID);
	
		void Restore(System.Guid aStudentID);
	
		void DeleteAllRemoved();
	
	}
	
	public partial class StudentR
		: BASE_RepositoryDbTable, IStudentR
	{
		public StudentR
			(IFbcBookItContext aDb): base(aDb)
		{
		}
	
		public bool Any()
		{
			bool vResult;
			vResult = _Db.StudentDb.Any();
			return vResult;
		}
	
		public bool Exists(System.Guid aStudentID)
		{
			bool vResult;
				vResult = _Db.StudentDb.Any(aRec => (aRec.StudentID == aStudentID));
			return vResult;
		}
	
		public Student Find(System.Guid aStudentID)
		{
			Student vResult;
			vResult = _Db.StudentDb.Single(aRec => (aRec.StudentID == aStudentID));
			return vResult;
		}
	
		public Student Get(System.Guid aStudentID)
		{
			Student vResult;
			vResult = _Db.StudentDb.FirstOrDefault(aRec => aRec.StudentID == aStudentID);
			return vResult;
		}
	
		public List<Student> GetAll()
		{
			List<Student> vResult;
			vResult = _Db.StudentDb.ToList();
			return vResult;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public Student Add(Student aStudent)
		{
			if (aStudent == null)
			{
				throw new ArgumentNullException("aStudent", " cannot be null!");
			}
	/*
			if (!aStudent.IsRootEntity())
			{
				aStudent.ClearToRootEntity();
			}
	*/
			if (!aStudent.IsNew())
			{
				const string MESSAGE = 
					"Student Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
				aStudent.AssignNewPK();
			aStudent = _Db.StudentDb.Add(aStudent);
			_Db.SaveChanges();
			return aStudent;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public void Insert(Student aStudent)
		{
			if (aStudent == null)
			{
				throw new ArgumentNullException("aStudent", " cannot be null!");
			}
	/*
			if (!aStudent.IsRootEntity())
			{
				aStudent.ClearToRootEntity();
			}
	*/
			if (!aStudent.IsNew())
			{
				const string MESSAGE = 
					"Student Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aStudent.AssignNewPK();
			_Db.StudentDb.Add(aStudent);
			_Db.SaveChanges();
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public System.Guid InsertAndReturnPrimaryKey(Student aStudent)
		{
			if (aStudent == null)
			{
				throw new ArgumentNullException("aStudent", " cannot be null!");
			}
	/*
			if (!aStudent.IsRootEntity())
			{
				aStudent.ClearToRootEntity();
			}
	*/
			if (!aStudent.IsNew())
			{
				const string MESSAGE = 
					"Student Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aStudent.AssignNewPK();
			aStudent = _Db.StudentDb.Add(aStudent);
			_Db.SaveChanges();
			System.Guid vResult = aStudent.StudentID;
			return vResult;
		}
	
		public void Update(Student aStudent)
		{
			Student vRec = 
				_Db.StudentDb.FirstOrDefault(aRec => aRec.StudentID == aStudent.StudentID);
			vRec.AssignFromNoPrimaryKeys(aStudent);
			_Db.SaveChanges();
		}
	
		public void Delete(System.Guid aStudentID)
		{
			Student vRec = 
				_Db.StudentDb.FirstOrDefault(aRec => aRec.StudentID == aStudentID);
			if (vRec == null)
			{
				return; // Record is already gone, no worries!
			}
			_Db.StudentDb.Remove(vRec);
			_Db.SaveChanges();
		}
	
		public bool IsActive(System.Guid aStudentID)
		{
			Student vRec = 
				_Db.StudentDb.FirstOrDefault(aRec => aRec.StudentID == aStudentID);
			bool vResult = (vRec != null) && vRec.Active;
			return vResult;
		}
	
		public void Remove(System.Guid aStudentID)
		{
			Student vRec = 
				_Db.StudentDb.FirstOrDefault(aRec => aRec.StudentID == aStudentID);
			if (vRec == null)
			{
				return;
			}
			vRec.Active = false;
			_Db.SaveChanges();
		}
	
		public void Restore(System.Guid aStudentID)
		{
			Student vRec = 
				_Db.StudentDb.FirstOrDefault(aRec => aRec.StudentID == aStudentID);
			if (vRec == null)
			{
				return;
			}
			vRec.Active = true;
			_Db.SaveChanges();
		}
	
		/// <remark>
		/// Note that this method in EF is Really Ugly in that EF requires that 
		/// each record to be deleted must first be brought into the context, then 
		/// "removed", then SaveChanges called to actually delete the record(s).
		/// For a large number of records this gets memory intensive.
		/// </remark>
		public void DeleteAllRemoved()
		{
			List<Student> vToDelete =
				_Db.StudentDb
					.Where(aRec => !aRec.Active).ToList();
			if (vToDelete.Count < 1)
			{
				return;
			}
			foreach (Student vRec in vToDelete)
			{
				_Db.StudentDb.Remove(vRec);
			}
			_Db.SaveChanges();
		}
	
	}
}