# RerunCenter

The ReRun Center is a tool for the Microsoft System Center Configuration Manager (SCCM) 2012 R2 to let you ReRun (i.e. execute) Software.
By default it is only possible to execute software as a package once per assignment and as an application until the detection method is fulfilled.

In our environment it is often needed to manually trigger a setup again to repair a broken isntallation or restore some default settings.
There is currently no tool I know of that can do this for Applications.
The aim of this program is to provide a GUI to manually trigger deployment of software packages independent of these conditions.

In the first release this tool only provides the means to rerun Applications as there are many great tools for rerunning packages already.
Package support is planned to be included later for the sake of completion.
If you want to rerun packages only I highly recommend using some other tool that is better tested.

This program works fine without side effects as far as I can tell, but my means of testing are limited so use it at your own risk.
It will write to the WMI and temporarily change settings about a specified Applications properties so be aware that permanent changes to the WMI are possible in case of an error.

I have only access to an SCCM2012 R2 environment but it will probably work with the original release as well. 
Using it with SCCM 2007 is pointless because applications are not present in that version. 
If you plan to use this with SCCM 2007 consider the SCCM Client Center instead.

# Limitations
* You need to be admin to run this tool (this will never change)
* You can currently only see ApplicationDeliveryTypes and not Applications in the list. This has something to do with the model of Applications. The support multiple different types of delivery so the Application itself can not be rerun only the Delivery. The only meaningful way to get a relation between those two I found so far uses the Site Server DB and this means only SCCM Admins could retrieve the information. If I find a way to get the relation locally it will be included, otherwise it will stay this way.
* Because of the above it is possible to "Re"run something that was never run. This will not change as it is a useful feature imo.
* Applications installed via the tool will not have the status installed in the Software Center. If they are chosen to be installed manually however, because of the detection method they will be moved to the isntalled section immediately and the setup will not be executed. This is therefore only a cosmetic issue but I plan on changing it if possible.
 
# Features
* Connect to any PC on your Site and view the Application Delivery Types
* ReRun any of the Applications displayed
* Can take a computername as commandline argument so it can be integrated as Extension in the SCCM Console via XML file
