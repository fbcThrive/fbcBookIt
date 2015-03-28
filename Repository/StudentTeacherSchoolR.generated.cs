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
	
	// Table Name: StudentTeacherSchool
	public partial interface IStudentTeacherSchoolR
		: IBASE_RepositoryDbTable
	{
		bool Any();
	
		bool Exists(System.Guid aID);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		StudentTeacherSchool Find(System.Guid aID);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		StudentTeacherSchool Get(System.Guid aID);
	
		List<StudentTeacherSchool> GetAll();
	
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
		StudentTeacherSchool Add(StudentTeacherSchool aStudentTeacherSchool);
	
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
		void Insert(StudentTeacherSchool aStudentTeacherSchool);
	
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
		System.Guid InsertAndReturnPrimaryKey(StudentTeacherSchool aStudentTeacherSchool);
	
		void Update(StudentTeacherSchool aStudentTeacherSchool);
	
		void Delete(System.Guid aID);
	
	}
	
	public partial class StudentTeacherSchoolR
		: BASE_RepositoryDbTable, IStudentTeacherSchoolR
	{
		public StudentTeacherSchoolR
			(IFbcBookItContext aDb): base(aDb)
		{
		}
	
		public bool Any()
		{
			bool vResult;
			vResult = _Db.StudentTeacherSchoolDb.Any();
			return vResult;
		}
	
		public bool Exists(System.Guid aID)
		{
			bool vResult;
				vResult = _Db.StudentTeacherSchoolDb.Any(aRec => (aRec.ID == aID));
			return vResult;
		}
	
		public StudentTeacherSchool Find(System.Guid aID)
		{
			StudentTeacherSchool vResult;
			vResult = _Db.StudentTeacherSchoolDb.Single(aRec => (aRec.ID == aID));
			return vResult;
		}
	
		public StudentTeacherSchool Get(System.Guid aID)
		{
			StudentTeacherSchool vResult;
			vResult = _Db.StudentTeacherSchoolDb.FirstOrDefault(aRec => aRec.ID == aID);
			return vResult;
		}
	
		public List<StudentTeacherSchool> GetAll()
		{
			List<StudentTeacherSchool> vResult;
			vResult = _Db.StudentTeacherSchoolDb.ToList();
			return vResult;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public StudentTeacherSchool Add(StudentTeacherSchool aStudentTeacherSchool)
		{
			if (aStudentTeacherSchool == null)
			{
				throw new ArgumentNullException("aStudentTeacherSchool", " cannot be null!");
			}
	/*
			if (!aStudentTeacherSchool.IsRootEntity())
			{
				aStudentTeacherSchool.ClearToRootEntity();
			}
	*/
			if (!aStudentTeacherSchool.IsNew())
			{
				const string MESSAGE = 
					"StudentTeacherSchool Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
				aStudentTeacherSchool.AssignNewPK();
			aStudentTeacherSchool = _Db.StudentTeacherSchoolDb.Add(aStudentTeacherSchool);
			_Db.SaveChanges();
			return aStudentTeacherSchool;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public void Insert(StudentTeacherSchool aStudentTeacherSchool)
		{
			if (aStudentTeacherSchool == null)
			{
				throw new ArgumentNullException("aStudentTeacherSchool", " cannot be null!");
			}
	/*
			if (!aStudentTeacherSchool.IsRootEntity())
			{
				aStudentTeacherSchool.ClearToRootEntity();
			}
	*/
			if (!aStudentTeacherSchool.IsNew())
			{
				const string MESSAGE = 
					"StudentTeacherSchool Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aStudentTeacherSchool.AssignNewPK();
			_Db.StudentTeacherSchoolDb.Add(aStudentTeacherSchool);
			_Db.SaveChanges();
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public System.Guid InsertAndReturnPrimaryKey(StudentTeacherSchool aStudentTeacherSchool)
		{
			if (aStudentTeacherSchool == null)
			{
				throw new ArgumentNullException("aStudentTeacherSchool", " cannot be null!");
			}
	/*
			if (!aStudentTeacherSchool.IsRootEntity())
			{
				aStudentTeacherSchool.ClearToRootEntity();
			}
	*/
			if (!aStudentTeacherSchool.IsNew())
			{
				const string MESSAGE = 
					"StudentTeacherSchool Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aStudentTeacherSchool.AssignNewPK();
			aStudentTeacherSchool = _Db.StudentTeacherSchoolDb.Add(aStudentTeacherSchool);
			_Db.SaveChanges();
			System.Guid vResult = aStudentTeacherSchool.ID;
			return vResult;
		}
	
		public void Update(StudentTeacherSchool aStudentTeacherSchool)
		{
			StudentTeacherSchool vRec = 
				_Db.StudentTeacherSchoolDb.FirstOrDefault(aRec => aRec.ID == aStudentTeacherSchool.ID);
			vRec.AssignFromNoPrimaryKeys(aStudentTeacherSchool);
			_Db.SaveChanges();
		}
	
		public void Delete(System.Guid aID)
		{
			StudentTeacherSchool vRec = 
				_Db.StudentTeacherSchoolDb.FirstOrDefault(aRec => aRec.ID == aID);
			if (vRec == null)
			{
				return; // Record is already gone, no worries!
			}
			_Db.StudentTeacherSchoolDb.Remove(vRec);
			_Db.SaveChanges();
		}
	
	}
}