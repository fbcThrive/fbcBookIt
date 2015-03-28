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
	
	// Table Name: Copy
	public partial interface ICopyR
		: IBASE_RepositoryDbTable
	{
		bool Any();
	
		bool Exists(System.Guid aCopyId);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		Copy Find(System.Guid aCopyId);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		Copy Get(System.Guid aCopyId);
	
		List<Copy> GetAll();
	
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
		Copy Add(Copy aCopy);
	
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
		void Insert(Copy aCopy);
	
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
		System.Guid InsertAndReturnPrimaryKey(Copy aCopy);
	
		void Update(Copy aCopy);
	
		void Delete(System.Guid aCopyId);
	
	}
	
	public partial class CopyR
		: BASE_RepositoryDbTable, ICopyR
	{
		public CopyR
			(IFbcBookItContext aDb): base(aDb)
		{
		}
	
		public bool Any()
		{
			bool vResult;
			vResult = _Db.CopyDb.Any();
			return vResult;
		}
	
		public bool Exists(System.Guid aCopyId)
		{
			bool vResult;
				vResult = _Db.CopyDb.Any(aRec => (aRec.CopyId == aCopyId));
			return vResult;
		}
	
		public Copy Find(System.Guid aCopyId)
		{
			Copy vResult;
			vResult = _Db.CopyDb.Single(aRec => (aRec.CopyId == aCopyId));
			return vResult;
		}
	
		public Copy Get(System.Guid aCopyId)
		{
			Copy vResult;
			vResult = _Db.CopyDb.FirstOrDefault(aRec => aRec.CopyId == aCopyId);
			return vResult;
		}
	
		public List<Copy> GetAll()
		{
			List<Copy> vResult;
			vResult = _Db.CopyDb.ToList();
			return vResult;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public Copy Add(Copy aCopy)
		{
			if (aCopy == null)
			{
				throw new ArgumentNullException("aCopy", " cannot be null!");
			}
	/*
			if (!aCopy.IsRootEntity())
			{
				aCopy.ClearToRootEntity();
			}
	*/
			if (!aCopy.IsNew())
			{
				const string MESSAGE = 
					"Copy Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
				aCopy.AssignNewPK();
			aCopy = _Db.CopyDb.Add(aCopy);
			_Db.SaveChanges();
			return aCopy;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public void Insert(Copy aCopy)
		{
			if (aCopy == null)
			{
				throw new ArgumentNullException("aCopy", " cannot be null!");
			}
	/*
			if (!aCopy.IsRootEntity())
			{
				aCopy.ClearToRootEntity();
			}
	*/
			if (!aCopy.IsNew())
			{
				const string MESSAGE = 
					"Copy Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aCopy.AssignNewPK();
			_Db.CopyDb.Add(aCopy);
			_Db.SaveChanges();
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public System.Guid InsertAndReturnPrimaryKey(Copy aCopy)
		{
			if (aCopy == null)
			{
				throw new ArgumentNullException("aCopy", " cannot be null!");
			}
	/*
			if (!aCopy.IsRootEntity())
			{
				aCopy.ClearToRootEntity();
			}
	*/
			if (!aCopy.IsNew())
			{
				const string MESSAGE = 
					"Copy Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aCopy.AssignNewPK();
			aCopy = _Db.CopyDb.Add(aCopy);
			_Db.SaveChanges();
			System.Guid vResult = aCopy.CopyId;
			return vResult;
		}
	
		public void Update(Copy aCopy)
		{
			Copy vRec = 
				_Db.CopyDb.FirstOrDefault(aRec => aRec.CopyId == aCopy.CopyId);
			vRec.AssignFromNoPrimaryKeys(aCopy);
			_Db.SaveChanges();
		}
	
		public void Delete(System.Guid aCopyId)
		{
			Copy vRec = 
				_Db.CopyDb.FirstOrDefault(aRec => aRec.CopyId == aCopyId);
			if (vRec == null)
			{
				return; // Record is already gone, no worries!
			}
			_Db.CopyDb.Remove(vRec);
			_Db.SaveChanges();
		}
	
	}
}