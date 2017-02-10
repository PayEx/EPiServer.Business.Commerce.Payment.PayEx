﻿using System;
using PayEx.EPi.Commerce.Payment.Contracts;
using PayEx.EPi.Commerce.Payment.Contracts.Commerce;
using PayEx.EPi.Commerce.Payment.Dectorators.PaymentCompleters;
using PayEx.EPi.Commerce.Payment.Dectorators.PaymentCreditors;
using PayEx.EPi.Commerce.Payment.Dectorators.PaymentInitializers;
using PayEx.EPi.Commerce.Payment.Models.Result;

namespace PayEx.EPi.Commerce.Payment.Models.PaymentMethods
{
    internal class DirectBankDebit : PaymentMethod
    {
        private readonly IPaymentManager _paymentManager;
        private readonly IParameterReader _parameterReader;
        private readonly ICartActions _cartActions;
        private readonly IOrderNumberGenerator _orderNumberGenerator;
        private readonly IAdditionalValuesFormatter _additionalValuesFormatter;
        private readonly IPaymentActions _paymentActions;
        public DirectBankDebit()  {  }

        public DirectBankDebit(Mediachase.Commerce.Orders.Payment payment, IPaymentManager paymentManager,
            IParameterReader parameterReader, ICartActions cartActions, IOrderNumberGenerator orderNumberGenerator, 
            IAdditionalValuesFormatter additionalValuesFormatter, IPaymentActions paymentActions)
            : base(payment)
        {
            _paymentManager = paymentManager;
            _parameterReader = parameterReader;
            _cartActions = cartActions;
            _orderNumberGenerator = orderNumberGenerator;
            _additionalValuesFormatter = additionalValuesFormatter;
            _paymentActions = paymentActions;
        }

        public override string PaymentMethodCode
        {
            get { return "DD"; }
        }

        public override string DefaultView
        {
            get { return "DIRECTDEBIT"; }
        }

        public override bool RequireAddressUpdate
        {
            get { return false; }
        }

        public override bool IsDirectModel
        {
            get { return false; }
        }

        public override PurchaseOperation PurchaseOperation
        {
            get { return PurchaseOperation.SALE; }
        }

        public override PaymentInitializeResult Initialize(Action<string> redirectAction)
        {
            IPaymentInitializer initializer = new GenerateOrderNumber(
                new InitializePayment(
                new RedirectUser(), _paymentManager, _parameterReader, _cartActions, _additionalValuesFormatter), _orderNumberGenerator);
            return initializer.Initialize(this, null, null, null, redirectAction);
        }

        public override PaymentCompleteResult Complete(string orderRef)
        {
            IPaymentCompleter completer = new CompletePayment(null, _paymentManager, _paymentActions);
            return completer.Complete(this, orderRef);
        }

        public override bool Capture()
        {
            return true; // Direct Bank Debit is done with PurchaseOperation=SALE, so Capture is not possible. Return true to continue execution.
        }

        public override bool Credit()
        {
            IPaymentCreditor creditor = new CreditPayment(null, _paymentManager);
            return creditor.Credit(this);
        }

        public override Address GetAddressFromPayEx(TransactionResult transactionResult)
        {
            return null;
        }
    }
}
