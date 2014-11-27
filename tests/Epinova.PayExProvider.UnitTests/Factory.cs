﻿
using Epinova.PayExProvider.Models.Result;

namespace Epinova.PayExProvider.UnitTests
{
    public static class Factory
    {
        public static string InitializeResult = "<?xml version=\"1.0\" encoding='utf-8' ?><payex><header name=\"Payex Header v1.0\"><id>4e0fbe36b146452b8ce7b87e6186a3e3</id><date>2010-11-10 06:13:48</date></header><status><code>OK</code><description>OK</description><errorCode>OK</errorCode><paramName /><thirdPartyError /></status><orderRef>b93d29bf7df3424cac23407a987c0be9</orderRef><sessionRef>7807accc0e7e4d069e1d92ec5680d0cc</sessionRef><redirectUrl>https://test-confined.payex.com/PxOrderCC.aspx?orderRef=b93d29bf7df3424cac23407a987c0be9</redirectUrl></payex>";

        public static string InitializeResultError = "<?xml version=\"1.0\" encoding='utf-8' ?><payex><header name=\"Payex Header v1.0\"><id>4e0fbe36b146452b8ce7b87e6186a3e3</id><date>2010-11-10 06:13:48</date></header><status><code>Error_Generic</code><description>Error_Generic</description><errorCode>Error_Generic</errorCode><paramName /><thirdPartyError /></status><orderRef></orderRef><sessionRef>7807accc0e7e4d069e1d92ec5680d0cc</sessionRef><redirectUrl>https://test-confined.payex.com/PxOrderCC.aspx?orderRef=b93d29bf7df3424cac23407a987c0be9</redirectUrl></payex>";

        public static string CompleteResult =
            "<?xml version=\"1.0\" encoding=\"utf-8\" ?><payex><header name=\"Payex Header v1.0\"><id>123456789abcdef123456789abcdef12</id><date>2010-09-29 04:54:15</date></header><status><code>OK</code><description>OK</description><errorCode>OK</errorCode><paramName /><thirdPartyError /></status><transactionStatus>3</transactionStatus><orderStatus>0</orderStatus><transactionRef>aaabbbcccdddeeefff11122233344455</transactionRef><transactionNumber>12345678</transactionNumber><orderId>123</orderId><productId>My Product</productId><paymentMethod>MC</paymentMethod><amount>2200</amount><alreadyCompleted>False</alreadyCompleted><clientAccount>0</clientAccount><productNumber>My Product</productNumber><clientGsmNumber /><BankHash>12345612-1234-1111-1234-000000000000</BankHash><AuthenticatedStatus>3DSecure</AuthenticatedStatus><AuthenticatedWith>Y</AuthenticatedWith><fraudData>false</fraudData></payex>";

        public static string CompleteResultError =
           "<?xml version=\"1.0\" encoding=\"utf-8\" ?><payex><header name=\"Payex Header v1.0\"><id>123456789abcdef123456789abcdef12</id><date>2010-09-29 04:54:15</date></header><status><code>InvalidAmount</code><description>InvalidAmount</description><errorCode>OK</errorCode><paramName /><thirdPartyError /></status><transactionStatus>3</transactionStatus><orderStatus>0</orderStatus><transactionRef>aaabbbcccdddeeefff11122233344455</transactionRef><transactionNumber>12345678</transactionNumber><orderId>123</orderId><productId>My Product</productId><paymentMethod>MC</paymentMethod><amount>2200</amount><alreadyCompleted>False</alreadyCompleted><clientAccount>0</clientAccount><productNumber>My Product</productNumber><clientGsmNumber /><BankHash>12345612-1234-1111-1234-000000000000</BankHash><AuthenticatedStatus>3DSecure</AuthenticatedStatus><AuthenticatedWith>Y</AuthenticatedWith><fraudData>false</fraudData><errorDetails><transactionErrorCode>InvalidAmount</transactionErrorCode></errorDetails></payex>";

        public static Status CreateStatus(bool success)
        {
            if (success)
                return new Status { Description = "OK", ErrorCode = "OK" };
            return new Status { Description = "NotOK", ErrorCode = "NotOK" };
        }
    }
}
