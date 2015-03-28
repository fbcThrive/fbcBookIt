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
	
	// Table Name: LoanStatus
	public partial interface ILoanStatusR
		: IBASE_RepositoryDbTable
	{
		bool Any();
	
		bool Exists(System.Int32 aLoanStatusId);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		LoanStatu Find(System.Int32 aLoanStatusId);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		LoanStatu Get(System.Int32 aLoanStatusId);
	
		List<LoanStatu> GetAll();
	
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
		LoanStatu Add(LoanStatu aLoanStatu);
	
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
		void Insert(LoanStatu aLoanStatu);
	
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
		System.Int32 InsertAndReturnPrimaryKey(LoanStatu aLoanStatu);
	
		void Update(LoanStatu aLoanStatu);
	
		void Delete(System.Int32 aLoanStatusId);
	
	}
	
	public partial class LoanStatusR
		: BASE_RepositoryDbTable, ILoanStatusR
	{
		public LoanStatusR
			(IFbcBookItContext aDb): base(aDb)
		{
		}
	
		public bool Any()
		{
			bool vResult;
			vResult = _Db.LoanStatuDb.Any();
			return vResult;
		}
	
		public bool Exists(System.Int32 aLoanStatusId)
		{
			bool vResult;
				vResult = _Db.LoanStatuDb.Any(aRec => (aRec.LoanStatusId == aLoanStatusId));
			return vResult;
		}
	
		public LoanStatu Find(System.Int32 aLoanStatusId)
		{
			LoanStatu vResult;
			vResult = _Db.LoanStatuDb.Single(aRec => (aRec.LoanStatusId == aLoanStatusId));
			return vResult;
		}
	
		public LoanStatu Get(System.Int32 aLoanStatusId)
		{
			LoanStatu vResult;
			vResult = _Db.LoanStatuDb.FirstOrDefault(aRec => aRec.LoanStatusId == aLoanStatusId);
			return vResult;
		}
	
		public List<LoanStatu> GetAll()
		{
			List<LoanStatu> vResult;
			vResult = _Db.LoanStatuDb.ToList();
			return vResult;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public LoanStatu Add(LoanStatu aLoanStatu)
		{
			if (aLoanStatu == null)
			{
				throw new ArgumentNullException("aLoanStatu", " cannot be null!");
			}
	/*
			if (!aLoanStatu.IsRootEntity())
			{
				aLoanStatu.ClearToRootEntity();
			}
	*/
			if (!aLoanStatu.IsNew())
			{
				const string MESSAGE = 
					"LoanStatu Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
				aLoanStatu.AssignNewPK();
			aLoanStatu = _Db.LoanStatuDb.Add(aLoanStatu);
			_Db.SaveChanges();
			return aLoanStatu;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public void Insert(LoanStatu aLoanStatu)
		{
			if (aLoanStatu == null)
			{
				throw new ArgumentNullException("aLoanStatu", " cannot be null!");
			}
	/*
			if (!aLoanStatu.IsRootEntity())
			{
				aLoanStatu.ClearToRootEntity();
			}
	*/
			if (!aLoanStatu.IsNew())
			{
				const string MESSAGE = 
					"LoanStatu Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aLoanStatu.AssignNewPK();
			_Db.LoanStatuDb.Add(aLoanStatu);
			_Db.SaveChanges();
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public System.Int32 InsertAndReturnPrimaryKey(LoanStatu aLoanStatu)
		{
			if (aLoanStatu == null)
			{
				throw new ArgumentNullException("aLoanStatu", " cannot be null!");
			}
	/*
			if (!aLoanStatu.IsRootEntity())
			{
				aLoanStatu.ClearToRootEntity();
			}
	*/
			if (!aLoanStatu.IsNew())
			{
				const string MESSAGE = 
					"LoanStatu Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aLoanStatu.AssignNewPK();
			aLoanStatu = _Db.LoanStatuDb.Add(aLoanStatu);
			_Db.SaveChanges();
			System.Int32 vResult = aLoanStatu.LoanStatusId;
			return vResult;
		}
	
		public void Update(LoanStatu aLoanStatu)
		{
			LoanStatu vRec = 
				_Db.LoanStatuDb.FirstOrDefault(aRec => aRec.LoanStatusId == aLoanStatu.LoanStatusId);
			vRec.AssignFromNoPrimaryKeys(aLoanStatu);
			_Db.SaveChanges();
		}
	
		public void Delete(System.Int32 aLoanStatusId)
		{
			LoanStatu vRec = 
				_Db.LoanStatuDb.FirstOrDefault(aRec => aRec.LoanStatusId == aLoanStatusId);
			if (vRec == null)
			{
				return; // Record is already gone, no worries!
			}
			_Db.LoanStatuDb.Remove(vRec);
			_Db.SaveChanges();
		}
	
	}
}
