# Harrier Carrier Post Deploy Tests
C# NUnit tests using ReqnRoll and Playwright to test the live website : https://Www.harriercarrier.com

## Requirements
- .NET 10


## Setup

Put repo into: C:\DEV\Repositories\GitHub\HarrierCarrierPostDeployTest

After 1st build: Open solution is Visual Studio --> Build --> Build Solution:

To install Playwright:
	Visual Studio --> View --> Terminal
		cd C:\DEV\Repositories\GitHub\HarrierCarrierPostDeployTest\HarrierCarrierPostDeployTest\HarrierCarrierPostDeployTest
		playwright install
		
(This will install files into: C:\Users\XXXX\AppData\Local\ms-playwright)
		
##run
	Visual Studio --> Test --> Test Explorer --> double green arrow runs all tests