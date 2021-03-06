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
	
	// Table Name: RequestStatus
	public partial interface IRequestStatusR
		: IBASE_RepositoryDbTable
	{
		bool Any();
	
		bool Exists(System.Int32 aRequestStatusId);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		RequestStatus Find(System.Int32 aRequestStatusId);
	
		// The only difference between "Find" and "Get" is that "Get" will return
		// a null if the record sought is not found whereas "Find" will throw
		// an exception.
		RequestStatus Get(System.Int32 aRequestStatusId);
	
		List<RequestStatus> GetAll();
	
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
		RequestStatus Add(RequestStatus aRequestStatus);
	
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
		void Insert(RequestStatus aRequestStatus);
	
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
		System.Int32 InsertAndReturnPrimaryKey(RequestStatus aRequestStatus);
	
		void Update(RequestStatus aRequestStatus);
	
		void Delete(System.Int32 aRequestStatusId);
	
		bool IsActive(System.Int32 aRequestStatusId);
	
		void Remove(System.Int32 aRequestStatusId);
	
		void Restore(System.Int32 aRequestStatusId);
	
		void DeleteAllRemoved();
	
	}
	
	public partial class RequestStatusR
		: BASE_RepositoryDbTable, IRequestStatusR
	{
		public RequestStatusR
			(IBookInventoryContext aDb): base(aDb)
		{
		}
	
		public bool Any()
		{
			bool vResult;
			vResult = _Db.RequestStatusDb.Any();
			return vResult;
		}
	
		public bool Exists(System.Int32 aRequestStatusId)
		{
			bool vResult;
				vResult = _Db.RequestStatusDb.Any(aRec => (aRec.RequestStatusId == aRequestStatusId));
			return vResult;
		}
	
		public RequestStatus Find(System.Int32 aRequestStatusId)
		{
			RequestStatus vResult;
			vResult = _Db.RequestStatusDb.Single(aRec => (aRec.RequestStatusId == aRequestStatusId));
			return vResult;
		}
	
		public RequestStatus Get(System.Int32 aRequestStatusId)
		{
			RequestStatus vResult;
			vResult = _Db.RequestStatusDb.FirstOrDefault(aRec => aRec.RequestStatusId == aRequestStatusId);
			return vResult;
		}
	
		public List<RequestStatus> GetAll()
		{
			List<RequestStatus> vResult;
			vResult = _Db.RequestStatusDb.ToList();
			return vResult;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public RequestStatus Add(RequestStatus aRequestStatus)
		{
			if (aRequestStatus == null)
			{
				throw new ArgumentNullException("aRequestStatus", " cannot be null!");
			}
	/*
			if (!aRequestStatus.IsRootEntity())
			{
				aRequestStatus.ClearToRootEntity();
			}
	*/
			if (!aRequestStatus.IsNew())
			{
				const string MESSAGE = 
					"RequestStatus Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
				aRequestStatus.AssignNewPK();
			aRequestStatus = _Db.RequestStatusDb.Add(aRequestStatus);
			_Db.SaveChanges();
			return aRequestStatus;
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public void Insert(RequestStatus aRequestStatus)
		{
			if (aRequestStatus == null)
			{
				throw new ArgumentNullException("aRequestStatus", " cannot be null!");
			}
	/*
			if (!aRequestStatus.IsRootEntity())
			{
				aRequestStatus.ClearToRootEntity();
			}
	*/
			if (!aRequestStatus.IsNew())
			{
				const string MESSAGE = 
					"RequestStatus Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aRequestStatus.AssignNewPK();
			_Db.RequestStatusDb.Add(aRequestStatus);
			_Db.SaveChanges();
		}
	
		/// <remark>
		/// Fragile:	This method presumes that any integer keys are
		///						auto-incrementing.
		/// </remark>
		public System.Int32 InsertAndReturnPrimaryKey(RequestStatus aRequestStatus)
		{
			if (aRequestStatus == null)
			{
				throw new ArgumentNullException("aRequestStatus", " cannot be null!");
			}
	/*
			if (!aRequestStatus.IsRootEntity())
			{
				aRequestStatus.ClearToRootEntity();
			}
	*/
			if (!aRequestStatus.IsNew())
			{
				const string MESSAGE = 
					"RequestStatus Insert failed. Record has failed \"IsNew\" test.";
				throw new Exception(MESSAGE);
			}
			aRequestStatus.AssignNewPK();
			aRequestStatus = _Db.RequestStatusDb.Add(aRequestStatus);
			_Db.SaveChanges();
			System.Int32 vResult = aRequestStatus.RequestStatusId;
			return vResult;
		}
	
		public void Update(RequestStatus aRequestStatus)
		{
			RequestStatus vRec = 
				_Db.RequestStatusDb.FirstOrDefault(aRec => aRec.RequestStatusId == aRequestStatus.RequestStatusId);
			vRec.AssignFromNoPrimaryKeys(aRequestStatus);
			_Db.SaveChanges();
		}
	
		public void Delete(System.Int32 aRequestStatusId)
		{
			RequestStatus vRec = 
				_Db.RequestStatusDb.FirstOrDefault(aRec => aRec.RequestStatusId == aRequestStatusId);
			if (vRec == null)
			{
				return; // Record is already gone, no worries!
			}
			_Db.RequestStatusDb.Remove(vRec);
			_Db.SaveChanges();
		}
	
		public bool IsActive(System.Int32 aRequestStatusId)
		{
			RequestStatus vRec = 
				_Db.RequestStatusDb.FirstOrDefault(aRec => aRec.RequestStatusId == aRequestStatusId);
			bool vResult = (vRec != null) && vRec.Active;
			return vResult;
		}
	
		public void Remove(System.Int32 aRequestStatusId)
		{
			RequestStatus vRec = 
				_Db.RequestStatusDb.FirstOrDefault(aRec => aRec.RequestStatusId == aRequestStatusId);
			if (vRec == null)
			{
				return;
			}
			vRec.Active = false;
			_Db.SaveChanges();
		}
	
		public void Restore(System.Int32 aRequestStatusId)
		{
			RequestStatus vRec = 
				_Db.RequestStatusDb.FirstOrDefault(aRec => aRec.RequestStatusId == aRequestStatusId);
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
			List<RequestStatus> vToDelete =
				_Db.RequestStatusDb
					.Where(aRec => !aRec.Active).ToList();
			if (vToDelete.Count < 1)
			{
				return;
			}
			foreach (RequestStatus vRec in vToDelete)
			{
				_Db.RequestStatusDb.Remove(vRec);
			}
			_Db.SaveChanges();
		}
	
	}
}
