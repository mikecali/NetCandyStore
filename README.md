# NetCandyStore
.NET Framework online Candy Store using Windows Containers in OpenShift

# Prerequisites
1. Access to an OpenShift cluster that supports Windows Containers
1. The `oc` command-line interface for OpenShift

# Table of Contents/Steps
1. Create a cluster that supports Windows Containers
1. Create a project `oc new-project netcandystore`
1. Create a MS SQL Server database
1. Populate the MS SQL Server database
1. Create the service 'netcandystore' using image netcandystore:v1
1. Create route for service 'netcandystore'
1. Create the service 'getcategories'
1. Replace the service 'netcandystore" using image netcandystore:v2

## Step 1: Create a cluster the supports Windows Containers
(some RHPDS magic here)

## Step 2: Create a project
At the command line, run the command  
`oc new-project netcandystore`

Alternatively, you can use the OpenShift console to create the new project "netcandystore".

## Step 3: Create a MS SQL Server database
For the purposes of this demo, this instance of MS SQL Server will run in our OpenShift cluster.

### Linux and macOS
Run the script `create_database.sh`  

### PowerShell
Run the script `create_database.ps1`

## Step 4: Populate the MS SQL Server database
### Linux and macOS
Run the script `populate_database.sh`
### PowerShell
Run the script `populate_database.ps1`
## Step 5: Create the service 'netcandystore' using image netcandystore:v1
## Step 6: Create route for service 'netcandystore'
## Step 7: Create the service 'getcategories'
## Step 8: Replace the service 'netcandystore' using image netcandystore:v2
