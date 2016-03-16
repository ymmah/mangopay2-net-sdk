﻿
namespace MangoPay.SDK.Core.Enumerations
{
    /// <summary>Method key enumeration.</summary>
    public enum MethodKey
    {
        AuthenticationBase,
        AuthenticationOAuth,
        CardGet,
        CardSave,
        CardRegistrationCreate,
        CardRegistrationGet,
        CardRegistrationSave,
        EventsAll,
        HooksAll,
        HooksCreate,
        HooksGet,
        HooksSave,
		PayinsPayPalCreate,
        PayinsBankwireDirectCreate,
        PayinsCardDirectCreate,
        PayinsCardWebCreate,
		PayinsCardWebGetCardData,
        PayinsCreateRefunds,
        PayinsGetRefunds,
        PayinsGet,
        PayinsPreauthorizedDirectCreate,
        PayinsDirectDebitCreate,
        PayoutsBankwireCreate,
        PayoutsGet,
        PreauthorizationCreate,
        PreauthorizationGet,
        PreauthorizationSave,
        RefundsGet,
        TransfersCreate,
        TransfersCreateRefunds,
        TransfersGet,
        TransfersGetRefunds,
        UsersAll,
        UsersAllBankAccount,
        UsersAllCards,
        UsersAllTransactions,
        UsersAllWallets,
        UsersCreateBankAccountsCa,
        UsersCreateBankAccountsGb,
        UsersCreateBankAccountsIban,
        UsersCreateBankAccountsOther,
        UsersCreateBankAccountsUs,
        UsersCreateKycDocument,
        UsersCreateKycPage,
        UsersCreateLegals,
        UsersCreateNaturals,
        UsersGet,
        UsersGetBankAccount,
        UsersGetKycDocument,
        UsersGetKycDocuments,
        UsersGetLegals,
        UsersGetNaturals,
        UsersSaveKycDocument,
        UsersSaveLegals,
        UsersSaveNaturals,
        WalletsAllTransactions,
        WalletsCreate,
        WalletsGet,
        WalletsSave,

        ClientGetKycDocuments,
        GetKycDocument,

		ClientGetWalletsDefault,
		ClientGetWalletsFees,
		ClientGetWalletsCredit,
		ClientGetWalletsDefaultWithCurrency,
		ClientGetWalletsFeesWithCurrency,
		ClientGetWalletsCreditWithCurrency,
		ClientGetTransactions,
		ClientGetWalletTransactions,
		ClientCreateBankwireDirect,
		
		DisputesGet,
		DisputesSaveTag,
		DisputesSaveContestFunds,
		DisputeSaveClose,

		DisputesGetTransactions,
		
		DisputesGetAll,
		DisputesGetForWallet,
		DisputesGetForUser,

		DisputesDocumentCreate,
		DisputesDocumentPageCreate,
		DisputesDocumentSubmit,
		DisputesDocumentGet,
		DisputesDocumentGetForDispute,
		DisputesDocumentGetForClient,

		DisputesRepudiationGet,

		DisputesRepudiationCreateSettlement,
		SettlementsGet,

		IdempotencyResponseGet,

		MandateCreate,
		MandateGet,
		MandateCancel,
		MandatesGetAll,
		MandatesGetForUser,
		MandatesGetForBankAccount
    }
}
