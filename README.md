# Custom Dotnet New Template Samples

This repository contains the demo templates from my talk at [Codegarden 2024](https://codegarden.umbraco.com/) entitled "Kick-start your way to speedy consistency; a guide to custom dotnet new templates". The video will be available for anyone to view in September; I'll add a link here when it is.

## Installing Locally

If you want to install and test these locally:

- Clone this repository
- Navigate to the `Templates` folder
- `cmd > dotnet new install .\`

## Templates

Each template is in its own folder inside `Templates`. Look at `.template.config\template.json` to see the configuration file for each template.

### AcmeIssueTemplates

`dotnet new acmeissuetemplates -n MyProject`

An **item** template that adds the .yml files in the correct folder structure so that, when pushed to GitHub, users posting new issues and feature requests will be asked to use a customised, more friendly template.

### AcmeReadme

`dotnet new acmereadme -n MyProject`

A **item** template for adding a readme file to the current working directory. 

It uses a 'derived' symbol to replace any instance of "FriendlySiteName" with a "friendly" version of the name parameter, i.e. one with spaces inserted. For example if `-n MyProject` is passed, then "FriendlySiteName" will be replaced with "My Project"

### AcmeUmbracoStarter

`dotnet new acmeumbracostarter -n MyProject`

A **project** template for starting a new Umbraco project which already has uSync installed, a hijacked controller and custom view model, and some starting CSS assets. This is just to demonstrate how you can create your own Umbraco template, this is not a starting position that I would actually recommend using!

The template.json file is configured to:
- Generate a new telemetry guid
- Not copy various folders, e.g. the Umbraco/Data folder
- Generate new http and https port numbers for working locally
- Support a custom parameter so that the user can decide to enable the Delivery API