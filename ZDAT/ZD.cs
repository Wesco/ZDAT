﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDAT
{
    public enum OP
    {
        Customer = 110,
        OrderNum = 113,
        Qty = 39,
        Product = 40,
        SO = 45,
        ProdCode = 51,
        Desc = 124,
        Add = 156,
        NewItem = 154,
        Order = 150,
        OrderHeader = 118,
        ShipToNum = 97,
        ShipToDesc = 95,
        ShipToOvr = 94,
        LineIncr = 18
    }

    public enum OH
    {
        Customer = 107,
        OrderNum = 109,
        SoldTo = 126,
        ShipToDesc = 128,
        ShipToNum = 13,
        OrderPad = 122,
        CustomerPO = 39,
        JobNumber = 40,
        EdiPO = 51,
        ShipTerms = 77,
        ShipTermsDesc = 80,
        ShipVia = 78,
        ShipViaDesc = 81,
        ShipAcctNum = 90,
        ShipInstruc = 79,
        Memo = 145,
        Inquiry = 146,
        Order = 147,
        Save = 117,
        Clear = 118,
        Close = 125
    }

    public enum OS
    {
        ByItem = 2,
        itmCatalogNum = 3,
        itmCustPartNum = 4,
        itmSIMNum = 6,
        itmNoneOfAbove = 7,
        ByOrder = 16,
        ordCustPONum = 8,
        ordOrderedBy = 9,
        ordQuotedTo = 10,
        ordJobNumber = 11,
        ordInsideSales = 12,
        ordOutsideSales = 13,
        ordInvoiceNum = 14,
        ordNoneOfAbove = 15,
        fltrCustFrom = 18,
        fltrCustTo = 21,
        fltrShipFrom = 25,
        fltrShipTo = 27,
        fltrItemSchShipDateFrom = 31,
        fltrItemSchShipDateTo = 33,
        fltrItemReqDateFrom = 37,
        fltrItemReqDateTo = 39,
        fltrOrdDateFrom = 43,
        fltrORdDateTo = 45,
        ClearFilterBy = 47,
        otypeAll = 50,
        otypeNormal = 51,
        otypeShipComplete = 52,
        otypeAssembleHold = 53,
        otypeShippedType = 54,
        ordsAll = 55,
        ordsOrders = 56,
        ordsInquiries = 57,
        ordsCreditMemo = 58,
        ordsMemos = 59,
        ordsOrdersInquiries = 60,
        ordsOrdersCreditMemo = 61,
        ostatusAll = 62,
        ostatusOpen = 63,
        ostatusClosed = 64,
        shipstatAll = 65,
        shipstatNotPicked = 66,
        shipstatPicked = 67,
        sipstatShipped = 68,
        shipstatInvoiced = 69,
        Search = 70,
        Clear = 71,
        CLose = 72
    }

    public enum OSR
    {
        OrderGrid = 2,
        OrderNum = 13,
        Cycle = 15,
        OrderStatus = 17,
        OrderType = 19,
        OrderedBy = 25,
        QuotedTo = 64,
        ShipTerms = 32,
        ShipTermsDesc = 34,
        ShipVia = 33,
        ShipViaDesc = 35,
        InSales = 42,
        OutSales = 43,
        CustPO = 21,
        JobNum = 23,
        CreatedBy = 45,
        InvoiceNum = 27,
        Type = 18,
        OrderTotal = 56,
        Supplier = 60,
        Customer = 6,
        CustomerDesc = 7,
        ViewRemoteOrder = 124,
        ViewRemotePO = 125,
        ViewReplCost = 126,
        ProductNotes = 128,
        ViewPO = 129,
        ViewOrder = 130,
        ManageOrder = 131,
        ShippingActivity = 132,
        NewSearch = 133,
        Close = 134,
        CustPartNum = 136,
        SIMNum = 65,
        ContractNo = 229,
        CurPrice = 224,
        LocalInventoryDesc = 110,
        Summary = 135
    }
}
