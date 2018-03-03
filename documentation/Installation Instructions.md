
The following document shows the prerequisites of the “Directions Map” feature and how to install it:

## Pre-requisites:

- Sitecore 9 update1
- Sitecore Experience Accelerator 1.6 rev. 180103 
- Sitecore PowerShell Extensions-4.7.2

## Steps:
- Install the package "Interactive Map.zip" that is provided.
- Create your Tenant and site.
- In order to add the Interactive Map to your site toolbox, you can run the following PowerShell script and make sure to replace the site name with your site name:
 
/sitecore/system/Modules/PowerShell/Script Library/Interactive Map Module/Add Interactive Map to site

--Image

4-	 The control can be added manually to your site toolbox by adding the following rendering to your site:

/sitecore/layout/Renderings/Feature/Interactive Maps/DirectionsMap

5-	Make sure to set the key in the Map Provider item under your site:
[Your site path] /Settings/Maps Provider

6-	Drag and drop the control from the SXA toolbox to your placeholder and select the map provider item from the popup.
