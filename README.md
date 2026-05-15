# Harrier Carrier Post Deploy Tests
C# NUnit tests using ReqnRoll and Playwright to test the live website : https://Www.harriercarrier.com

## Requirements
- .NET 10
- Node

## Setup
Put repo into: C:\DEV\Repositories\GitHub\HarrierCarrierPostDeployTest

After 1st build: Open solution is Visual Studio --> Build --> Build Solution:

(This will install Playwright and put files into: C:\Users\XXXX\AppData\Local\ms-playwright)
This project uses **Playwright for .NET** as the browser automation engine in C# tests.  
It’s different from the npm‑based **Playwright Test Runner** (JS/TS) which handles test execution and HTML reports.
	Visual Studio --> View --> Terminal
		cd C:\DEV\Repositories\GitHub\HarrierCarrierPostDeployTest\HarrierCarrierPostDeployTest\HarrierCarrierPostDeployTest
		playwright install
		
##run
	Visual Studio --> Test --> Test Explorer --> double green arrow runs all tests