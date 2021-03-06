﻿using System;
using MangoPay.SDK.Core.Enumerations;
using MangoPay.SDK.Entities;
using MangoPay.SDK.Entities.GET;

namespace MangoPay.SDK.Core.APIs
{
    /// <summary>API for refunds.</summary>
    public class ApiRefunds : ApiBase
    {
        /// <summary>Instantiates new ApiRefunds object.</summary>
        /// <param name="root">Root/parent instance that holds the OAuthToken and Configuration instance.</param>
        public ApiRefunds(MangoPayApi root) : base(root) { }

        /// <summary>Gets refund.</summary>
        /// <param name="refundId">Refund identifier.</param>
        /// <returns>Refund entity instance returned from API.</returns>
        public RefundDTO Get(string refundId)
        {
            return this.GetObject<RefundDTO>(MethodKey.RefundsGet, refundId);
        }

		/// <summary>Lists refunds for a payout</summary>
		/// <param name="payOutId">Id of the payout to get refunds for</param>
		/// <param name="pagination">Pagination.</param>
		/// <param name="filter">Filter.</param>
		/// <param name="sort">Sort.</param>
		/// <returns>List of refunds for a payout</returns>
		public ListPaginated<RefundDTO> GetRefundsForPayOut(String payOutId, Pagination pagination, FilterRefunds filters, Sort sort = null)
		{
			if (filters == null) filters = new FilterRefunds();

			return GetList<RefundDTO>(MethodKey.PayoutsGetRefunds, pagination, payOutId, sort, filters.GetValues());
		}

		/// <summary>Lists refunds for a payin</summary>
		/// <param name="payInId">Id of the payin to get refunds for</param>
		/// <param name="pagination">Pagination.</param>
		/// <param name="filter">Filter.</param>
		/// <param name="sort">Sort.</param>
		/// <returns>List of refunds for a payin</returns>
		public ListPaginated<RefundDTO> GetRefundsForPayIn(String payInId, Pagination pagination, FilterRefunds filters, Sort sort = null)
		{
			if (filters == null) filters = new FilterRefunds();

			return GetList<RefundDTO>(MethodKey.PayinsGetRefunds, pagination, payInId, sort, filters.GetValues());
		}

		/// <summary>Lists refunds for a transfer</summary>
		/// <param name="transferId">Id of the transfer to get refunds for</param>
		/// <param name="pagination">Pagination.</param>
		/// <param name="filter">Filter.</param>
		/// <param name="sort">Sort.</param>
		/// <returns>List of refunds for a transfer</returns>
		public ListPaginated<RefundDTO> GetRefundsForTransfer(String transferId, Pagination pagination, FilterRefunds filters, Sort sort = null)
		{
			if (filters == null) filters = new FilterRefunds();

			return GetList<RefundDTO>(MethodKey.TransfersGetRefunds, pagination, transferId, sort, filters.GetValues());
		}

		/// <summary>Lists refunds for a repudiation</summary>
		/// <param name="repudiationId">Id of the repudiation to get refunds for</param>
		/// <param name="pagination">Pagination.</param>
		/// <param name="filter">Filter.</param>
		/// <param name="sort">Sort.</param>
		/// <returns>List of refunds for a repudiation</returns>
		public ListPaginated<RefundDTO> GetRefundsForRepudiation(String repudiationId, Pagination pagination, FilterRefunds filters, Sort sort = null)
		{
			if (filters == null) filters = new FilterRefunds();

			return GetList<RefundDTO>(MethodKey.DisputesRepudiationGetRefunds, pagination, repudiationId, sort, filters.GetValues());
		}
	}
}
