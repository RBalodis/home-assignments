*** 
# Homework: Frontend 
You are developing a UI for a <a href="https://www.xe.com/currencyconverter/">currency calculator</a> with configurable conversion fees. There is a fee configuration section and a calculator section. The former allows the user to edit individual conversion fees for currency pairs. The latter is used to calculate the conversions.

## Requirements
***
* Create a UI section for editing a list of currency conversion fees.
* Create a UI section for calculating a conversion that optionally includes a fee, if it is configured.
* Fetch current conversion rates for the preview from <a href="https://www.ecb.europa.eu/stats/policy_and_exchange_rates/euro_reference_exchange_rates/html/index.en.html">ECB</a>. Note that the <a href="https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml">reference rates endpoint</a> provides data in XML, not in JSON.

### Fee Editor
* Fees can be added, changed or removed for a given currency pair and direction.
* Fees apply exactly in the configured direction (e.g. from EUR to GBP), but not in reverse.
* Fees are specified as fractions, i.e. 0.2 for a 20% fee.

### Currency Conversion Preview
* It should be possible to enter the amount to be converted, which currency to convert from, and which to convert to.
* If a fee is configured for the specified currency pair, it should apply to the conversion result.
* If no fee is set, a default one is used.
* The default fee is supplied in application configuration.
* The conversion is calculated using the formula: (amount - amount * fee) * rate.

## Non-functional Requirements
***
* Stack: TypeScript, React.
* The solution should be built and served using either Create React App, webpack, or Parcel. A production build is not required.
* The solution should work entirely on the client side.
* ECB endpoint doesn't set CORS headers, so you will have to configure a proxy. The build tools listed above all support this feature.

## Considerations
***
* It should be possible to build and run the solution from the command-line.
* You should provide a README file that clearly explains how to do the above.