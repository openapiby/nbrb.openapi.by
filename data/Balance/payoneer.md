Request.
```
-X GET 
https://api.sandbox.payoneer.com/v4/accounts/{account_id}/balances
-H "Content-Type: application/json" 
-H “Authorization: Bearer MXVNd2NTcTBlTi94NkZC…”
```

Reponse.
```
{ 
  {
        "items": [ 
        { 
            "id": "4366181865108056", 
            "type": "BALANCE", 
            "currency": "GBP", 
            "status": "2", 
            "status_description": "Active", 
            "available_balance": "20.00", 
            "update_time": "2018-03-30T19:28:17Z" 
        }
        ],
        "total": 1
     }
}
```

Ref. https://developer.payoneer.com/docs/OpenAPI/GettingStartedGuide/use-cases/platforms_applications/CollectPaymentsFromCustomersWorld-wide/1_charge
