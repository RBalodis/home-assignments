## 1) Suppose we have two tables keeping financial instruments trading information on the market for the END of the day.

First table "INSTRUMENTS" stores information on financial instruments available:
Table "INSTRUMENTS" columns ("ISIN" ; "INSTRUMENT_NAME")

Second table "PRICES" stores information about instrument market prices.
Each row of "PRICES" table has instrument ISIN number, price date (on daily basis) and unit price.
Table "PRICES" columns ("ISIN" ; "PRICE_DATE", 'UNIT_PRICE')

The price of instrument is saved once at the end of date if there appears financial instrument trade deal on the market.
It means that for the particular date table "PRICES" contains one price for instrument and only for those instruments that were traded on that date.

Write a query which would return latest instrument price known for particular date.

E.G. for date X the result should output:
`DATE(x) ; ISIN ; PRICE`

NOTE: if there has been no deal for an instrument before date X query should return 0 as price.

## 2.) Write a query which would return latest known instrument price for particular date only for those instruments that had more than 10 different prices for the period starting year before day X and ending 3 months after day x.

E.G. for date X the result should output:
```bash
DATE(x);
ISIN;
PRICE;
PRICE_NB(number of different instrument prices for defined period)
PRICE_NB_BEFORE(number of different instrument prices 6 months before day X)
PRICE_NB_AFTER(number of different instrument prices 1 month after day X)
```