# PrestoShop
This is the solution with tests for [PrestoShop](http://prestashop.qatestlab.com.ua/ru/) Web Application

## Features
- UI tests
- Logging
- Allure report

## Tests list

#### UI
- Tests_for_adding_an_item_to_the_cart:

1)AddCard

- Authorization_tests:

1)LoginWithStandartUserWithBaseElement

2)LoginUserWithoutName

3)RandomUserTest

4)LoginStandartUser

- End2End:

1)End2EndCheckout

2)End2EndCheckoutUSA


- Registration_tests:

1)Create

2)Registration

3)CreateUser




## Technologies
**NuGet packages used in the solution:**
- Microsoft.NET.Test.Sdk
- Allure.NUnit
- Bogus
- NLog
- NUnit
- Selenium.Support
- Selenium.WebDriver
- Faker.Net

**Approaches used in the development of the framework and tests:**
- Driver Factory
- Page Object
- Wrappers
- Chain of invocation

## Configuration
The solution uses a configuration .runsettings file:
```BrowserSetUp.runsettings```
```
<RunSettings>
	<TestRunParameters>
		<Parameter name ="Headless" value="false"/>
		<Parameter name ="BrowserType" value="Chrome"/>
		<Parameter name ="ImplicityWait" value="10"/>
		<Parameter name ="StandartUserName" value="testRoman@email.ru"/>
		<Parameter name ="StandartPassword" value="12345"/>
	</TestRunParameters>
</RunSettings>

```

## Installation
Register on the [PrestoShop](http://prestashop.qatestlab.com.ua/ru/)
Replace **Url**, **Login**, **Password** in the config file
You are ready to run UI tests
