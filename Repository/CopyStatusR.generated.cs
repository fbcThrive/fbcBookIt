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
	
	// Table Name: CopyStatus
	public partial interface ICopyStatusR
		: IBASE_RepositoryDbTable
	{
		bool Any();
	
		bool Exists(System.Int32 aCopyStatusId);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		CopyStatu Find(System.Int32 aCopyStatusId);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		CopyStatu Get(System.Int32 aCopyStatusId);
	
		List<CopyStatu> GetAll();
	
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
		CopyStatu Add(CopyStatu aCopyStatu);
	
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
		void Insert(CopyStatu aCopyStatu);
	
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
		System.Int32 InsertAndReturnPrimaryKey(CopyStatu aCopyStatu);
	
		void Update(CopyStatu aCopyStatu);
	
		void Delete(System.Int32 aCopyStatusId);
	
	}
	
	public partial class CopyStatusR
		: BASE_RepositoryDbTable, ICopyStatusR
	{
		public CopyStatusR
			(IFbcBookItContext aDb): base(aDb)
		{
		}
	
		public bool Any()
		{
			bool vResult;
			vResult = _Db.CopyStatuDb.Any();
			return vResult;
		}
	
		public bool Exists(System.Int32 aCopyStatusId)
		{
			bool vResult;
				vResult = _Db.CopyStatuDb.Any(aRec => (aRec.CopyStatusId == aCopyStatusId));
			return vResult;
		}
	
		public CopyStatu Find(System.Int32 aCopyStatusId)
		{
			CopyStatu vResult;
			vResult = _Db.CopyStatuDb.Single(aRec => (aRec.CopyStatusId == aCopyStatusId));
			return vResult;
		}
	
		public CopyStatu Get(System.Int32 aCopyStatusId)
		{
			CopyStatu vResult;
			vResult = _Db.CopyStatuDb.FirstOrDefault(aRec => aRec.CopyStatusId == aCopyStatusId);
			return vResult;
		}
	
		public List<CopyStatu> GetAll()
		{
			List<CopyStatu> vResult;
			vResult = _Db.CopyStatuDb.ToList();
			return vResult;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public CopyStatu Add(CopyStatu aCopyStatu)
		{
			if (aCopyStatu == null)
			{
				throw new ArgumentNullException("aCopyStatu", " cannot be null!");
			}
	/*
			if (!aCopyStatu.IsRootEntity())
			{
				aCopyStatu.ClearToRootEntity();
			}
	*/
			if (!aCopyStatu.IsNew())
			{
				const string MESSAGE = 
					"CopyStatu Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
				aCopyStatu.AssignNewPK();
			aCopyStatu = _Db.CopyStatuDb.Add(aCopyStatu);
			_Db.SaveChanges();
			return aCopyStatu;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public void Insert(CopyStatu aCopyStatu)
		{
			if (aCopyStatu == null)
			{
				throw new ArgumentNullException("aCopyStatu", " cannot be null!");
			}
	/*
			if (!aCopyStatu.IsRootEntity())
			{
				aCopyStatu.ClearToRootEntity();
			}
	*/
			if (!aCopyStatu.IsNew())
			{
				const string MESSAGE = 
					"CopyStatu Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aCopyStatu.AssignNewPK();
			_Db.CopyStatuDb.Add(aCopyStatu);
			_Db.SaveChanges();
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public System.Int32 InsertAndReturnPrimaryKey(CopyStatu aCopyStatu)
		{
			if (aCopyStatu == null)
			{
				throw new ArgumentNullException("aCopyStatu", " cannot be null!");
			}
	/*
			if (!aCopyStatu.IsRootEntity())
			{
				aCopyStatu.ClearToRootEntity();
			}
	*/
			if (!aCopyStatu.IsNew())
			{
				const string MESSAGE = 
					"CopyStatu Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aCopyStatu.AssignNewPK();
			aCopyStatu = _Db.CopyStatuDb.Add(aCopyStatu);
			_Db.SaveChanges();
			System.Int32 vResult = aCopyStatu.CopyStatusId;
			return vResult;
		}
	
		public void Update(CopyStatu aCopyStatu)
		{
			CopyStatu vRec = 
				_Db.CopyStatuDb.FirstOrDefault(aRec => aRec.CopyStatusId == aCopyStatu.CopyStatusId);
			vRec.AssignFromNoPrimaryKeys(aCopyStatu);
			_Db.SaveChanges();
		}
	
		public void Delete(System.Int32 aCopyStatusId)
		{
			CopyStatu vRec = 
				_Db.CopyStatuDb.FirstOrDefault(aRec => aRec.CopyStatusId == aCopyStatusId);
			if (vRec == null)
			{
				return; // Record is already gone, no worries!
			}
			_Db.CopyStatuDb.Remove(vRec);
			_Db.SaveChanges();
		}
	
	}
}
