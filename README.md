# Trezor.Net
Cross Platform C# Library for the Trezor Cryptocurrency Hardwarewallet

Join us on Slack:
https://hardwarewallets.slack.com

Twitter:
https://twitter.com/HardfolioApp

Currently supports:
* .NET Framework
* .NET Core
* Android
* UWP 

## Quick Start

- Clone the repo and open the solution
- There is a console sample, Xamarin Forms sample and unit tests for UWP, and .NET
- Compile one of the unit test apps, run the UWP/Android Xamarin Forms apps or,
- Go to Test->Windows->Text Explorer in Visual Studio
- Run one of the unit tests in the pane.
- Note that the UWP unit test has a UI for entering the pin. Please read instructions there. 

These samples mostly show you how to get addresses and sign transactions, but samples for other messages are being added.

Note: not all messages have a public method, but all messages exist. If you want to send a message to the Trezor you need to construct the message object and send it to the Trezor with the SendMessageAsync method. This requires that you know the result type before calling.

## NuGet

Install-Package Trezor.Net

## Hardwarewallets.Net

This library is part of the Hardwarewallets.Net suite of libraries. It is an ambitious project aimed toward putting a set of common C# interfaces across all hardwarewallets

https://github.com/MelbourneDeveloper/Hardwarewallets.Net

## Contribution

I welcome feedback, and pull requests. If there's something that you need to change in the library, please log an issue, and explain the problem. If you have a proposed solution, please write it up and explain why you think it is the answer to the problem. The best way to highlight a bug is to submit a pull request with a unit test that fails so I can clearly see what the problem is in the first place.

### Pull Requests

Please break pull requests up in to their smallest possible parts. If you have a small feature of refactor that other code depends on, try submitting that first. Please try to reference an issue so that I understand the context of the pull request. If there is no issue, I don't know what the code is about. If you need help, please jump on Slack here: https://hardwarewallets.slack.com

## Donate

All Hardwarewallets.Net libraries are open source and free. Your donations will contribute to making sure that these libraries keep up with the latest hardwarewallet firmware, functions are implemented, and the quality is maintained.

Bitcoin: 33LrG1p81kdzNUHoCnsYGj6EHRprTKWu3U

Ethereum: 0x7ba0ea9975ac0efb5319886a287dcf5eecd3038e

Litecoin: MVAbLaNPq7meGXvZMU4TwypUsDEuU6stpY

## Store App Production Usage

This app currently only Supports Trezor (https://github.com/MelbourneDeveloper/Trezor.Net) but it will soon support Ledger with this library.

https://play.google.com/store/apps/details?id=com.Hardfolio (Android)

https://www.microsoft.com/en-au/p/hardfolio/9p8xx70n5d2j (UWP)

## Hid.Net

Trezor.Net communicates with the device via the Hid.Net library. You can see the repo for this library here:

https://github.com/MelbourneDeveloper/Hid.Net

## See Also

These are the Trezor firmware open sources repos:

### Trezor One
https://github.com/trezor/trezor-mcu

### Trezor Model T (Not Yet Supported)
https://github.com/trezor/trezor-core

### Trezor Android Library - A client which is similar in design to Trezor.Net
https://github.com/trezor/trezor-android


