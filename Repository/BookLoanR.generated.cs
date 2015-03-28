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
	
	// Table Name: BookLoan
	public partial interface IBookLoanR
		: IBASE_RepositoryDbTable
	{
		bool Any();
	
		bool Exists(System.Guid aBookLoanId);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		BookLoan Find(System.Guid aBookLoanId);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		BookLoan Get(System.Guid aBookLoanId);
	
		List<BookLoan> GetAll();
	
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
		BookLoan Add(BookLoan aBookLoan);
	
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
		void Insert(BookLoan aBookLoan);
	
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
		System.Guid InsertAndReturnPrimaryKey(BookLoan aBookLoan);
	
		void Update(BookLoan aBookLoan);
	
		void Delete(System.Guid aBookLoanId);
	
	}
	
	public partial class BookLoanR
		: BASE_RepositoryDbTable, IBookLoanR
	{
		public BookLoanR
			(IFbcBookItContext aDb): base(aDb)
		{
		}
	
		public bool Any()
		{
			bool vResult;
			vResult = _Db.BookLoanDb.Any();
			return vResult;
		}
	
		public bool Exists(System.Guid aBookLoanId)
		{
			bool vResult;
				vResult = _Db.BookLoanDb.Any(aRec => (aRec.BookLoanId == aBookLoanId));
			return vResult;
		}
	
		public BookLoan Find(System.Guid aBookLoanId)
		{
			BookLoan vResult;
			vResult = _Db.BookLoanDb.Single(aRec => (aRec.BookLoanId == aBookLoanId));
			return vResult;
		}
	
		public BookLoan Get(System.Guid aBookLoanId)
		{
			BookLoan vResult;
			vResult = _Db.BookLoanDb.FirstOrDefault(aRec => aRec.BookLoanId == aBookLoanId);
			return vResult;
		}
	
		public List<BookLoan> GetAll()
		{
			List<BookLoan> vResult;
			vResult = _Db.BookLoanDb.ToList();
			return vResult;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public BookLoan Add(BookLoan aBookLoan)
		{
			if (aBookLoan == null)
			{
				throw new ArgumentNullException("aBookLoan", " cannot be null!");
			}
	/*
			if (!aBookLoan.IsRootEntity())
			{
				aBookLoan.ClearToRootEntity();
			}
	*/
			if (!aBookLoan.IsNew())
			{
				const string MESSAGE = 
					"BookLoan Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
				aBookLoan.AssignNewPK();
			aBookLoan = _Db.BookLoanDb.Add(aBookLoan);
			_Db.SaveChanges();
			return aBookLoan;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public void Insert(BookLoan aBookLoan)
		{
			if (aBookLoan == null)
			{
				throw new ArgumentNullException("aBookLoan", " cannot be null!");
			}
	/*
			if (!aBookLoan.IsRootEntity())
			{
				aBookLoan.ClearToRootEntity();
			}
	*/
			if (!aBookLoan.IsNew())
			{
				const string MESSAGE = 
					"BookLoan Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aBookLoan.AssignNewPK();
			_Db.BookLoanDb.Add(aBookLoan);
			_Db.SaveChanges();
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public System.Guid InsertAndReturnPrimaryKey(BookLoan aBookLoan)
		{
			if (aBookLoan == null)
			{
				throw new ArgumentNullException("aBookLoan", " cannot be null!");
			}
	/*
			if (!aBookLoan.IsRootEntity())
			{
				aBookLoan.ClearToRootEntity();
			}
	*/
			if (!aBookLoan.IsNew())
			{
				const string MESSAGE = 
					"BookLoan Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aBookLoan.AssignNewPK();
			aBookLoan = _Db.BookLoanDb.Add(aBookLoan);
			_Db.SaveChanges();
			System.Guid vResult = aBookLoan.BookLoanId;
			return vResult;
		}
	
		public void Update(BookLoan aBookLoan)
		{
			BookLoan vRec = 
				_Db.BookLoanDb.FirstOrDefault(aRec => aRec.BookLoanId == aBookLoan.BookLoanId);
			vRec.AssignFromNoPrimaryKeys(aBookLoan);
			_Db.SaveChanges();
		}
	
		public void Delete(System.Guid aBookLoanId)
		{
			BookLoan vRec = 
				_Db.BookLoanDb.FirstOrDefault(aRec => aRec.BookLoanId == aBookLoanId);
			if (vRec == null)
			{
				return; // Record is already gone, no worries!
			}
			_Db.BookLoanDb.Remove(vRec);
			_Db.SaveChanges();
		}
	
	}
}