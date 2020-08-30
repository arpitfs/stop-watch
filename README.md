# StopWatch
This is .net core mvc application the whole project was like this application is containerized in docker and hosted on Azure container instance. On hitting the buttons on UI a message is sent to ASB specifically to queue which is monitored by Azure function which picks up the message and send it to slack channel using incoming web hooks api


![alt text](https://github.com/ArpitMalik123/StopWatch/blob/master/Stpowatch_Flow.png)
