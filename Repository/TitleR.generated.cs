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
	
	// Table Name: Title
	public partial interface ITitleR
		: IBASE_RepositoryDbTable
	{
		bool Any();
	
		bool Exists(System.Guid aID);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		Title Find(System.Guid aID);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		Title Get(System.Guid aID);
	
		List<Title> GetAll();
	
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
		Title Add(Title aTitle);
	
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
		void Insert(Title aTitle);
	
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
		System.Guid InsertAndReturnPrimaryKey(Title aTitle);
	
		void Update(Title aTitle);
	
		void Delete(System.Guid aID);
	
		bool IsActive(System.Guid aID);
	
		void Remove(System.Guid aID);
	
		void Restore(System.Guid aID);
	
		void DeleteAllRemoved();
	
	}
	
	public partial class TitleR
		: BASE_RepositoryDbTable, ITitleR
	{
		public TitleR
			(IFbcBookItContext aDb): base(aDb)
		{
		}
	
		public bool Any()
		{
			bool vResult;
			vResult = _Db.TitleDb.Any();
			return vResult;
		}
	
		public bool Exists(System.Guid aID)
		{
			bool vResult;
				vResult = _Db.TitleDb.Any(aRec => (aRec.ID == aID));
			return vResult;
		}
	
		public Title Find(System.Guid aID)
		{
			Title vResult;
			vResult = _Db.TitleDb.Single(aRec => (aRec.ID == aID));
			return vResult;
		}
	
		public Title Get(System.Guid aID)
		{
			Title vResult;
			vResult = _Db.TitleDb.FirstOrDefault(aRec => aRec.ID == aID);
			return vResult;
		}
	
		public List<Title> GetAll()
		{
			List<Title> vResult;
			vResult = _Db.TitleDb.ToList();
			return vResult;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public Title Add(Title aTitle)
		{
			if (aTitle == null)
			{
				throw new ArgumentNullException("aTitle", " cannot be null!");
			}
	/*
			if (!aTitle.IsRootEntity())
			{
				aTitle.ClearToRootEntity();
			}
	*/
			if (!aTitle.IsNew())
			{
				const string MESSAGE = 
					"Title Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
				aTitle.AssignNewPK();
			aTitle = _Db.TitleDb.Add(aTitle);
			_Db.SaveChanges();
			return aTitle;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public void Insert(Title aTitle)
		{
			if (aTitle == null)
			{
				throw new ArgumentNullException("aTitle", " cannot be null!");
			}
	/*
			if (!aTitle.IsRootEntity())
			{
				aTitle.ClearToRootEntity();
			}
	*/
			if (!aTitle.IsNew())
			{
				const string MESSAGE = 
					"Title Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aTitle.AssignNewPK();
			_Db.TitleDb.Add(aTitle);
			_Db.SaveChanges();
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public System.Guid InsertAndReturnPrimaryKey(Title aTitle)
		{
			if (aTitle == null)
			{
				throw new ArgumentNullException("aTitle", " cannot be null!");
			}
	/*
			if (!aTitle.IsRootEntity())
			{
				aTitle.ClearToRootEntity();
			}
	*/
			if (!aTitle.IsNew())
			{
				const string MESSAGE = 
					"Title Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aTitle.AssignNewPK();
			aTitle = _Db.TitleDb.Add(aTitle);
			_Db.SaveChanges();
			System.Guid vResult = aTitle.ID;
			return vResult;
		}
	
		public void Update(Title aTitle)
		{
			Title vRec = 
				_Db.TitleDb.FirstOrDefault(aRec => aRec.ID == aTitle.ID);
			vRec.AssignFromNoPrimaryKeys(aTitle);
			_Db.SaveChanges();
		}
	
		public void Delete(System.Guid aID)
		{
			Title vRec = 
				_Db.TitleDb.FirstOrDefault(aRec => aRec.ID == aID);
			if (vRec == null)
			{
				return; // Record is already gone, no worries!
			}
			_Db.TitleDb.Remove(vRec);
			_Db.SaveChanges();
		}
	
		public bool IsActive(System.Guid aID)
		{
			Title vRec = 
				_Db.TitleDb.FirstOrDefault(aRec => aRec.ID == aID);
			bool vResult = (vRec != null) && vRec.Active;
			return vResult;
		}
	
		public void Remove(System.Guid aID)
		{
			Title vRec = 
				_Db.TitleDb.FirstOrDefault(aRec => aRec.ID == aID);
			if (vRec == null)
			{
				return;
			}
			vRec.Active = false;
			_Db.SaveChanges();
		}
	
		public void Restore(System.Guid aID)
		{
			Title vRec = 
				_Db.TitleDb.FirstOrDefault(aRec => aRec.ID == aID);
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
			List<Title> vToDelete =
				_Db.TitleDb
					.Where(aRec => !aRec.Active).ToList();
			if (vToDelete.Count < 1)
			{
				return;
			}
			foreach (Title vRec in vToDelete)
			{
				_Db.TitleDb.Remove(vRec);
			}
			_Db.SaveChanges();
		}
	
	}
}