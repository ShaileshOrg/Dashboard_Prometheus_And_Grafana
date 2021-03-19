# Dashboard_Prometheus_And_Grafana
## This project will help you understand how to use Prometheus and Grafana to build application Dashboard

https://shailesh-bakadia.atlassian.net/wiki/spaces/SL/pages/59670529/Create+Dashboard+with+Prometheus+and+Grafana

## Add follwing nugetpackages
/*1. App.Metrics.AspNetCore
2. App.Metrics.AspNetCore.Endpoints
3. App.Metrics.AspNetCore.Tracking
4. App.Metrics.Formatters.Prometheus*/

5. prometheus-net
6. prometheus-net.AspNetCore 
## Now add app.UseMetricServer(5000, "/metrics"); under Startup.cs > Configure method
## Run Prometheses server
## Run Grafan server
## visit http://localhost:9090 for prometheses log
## visit http://localhost:3000 for grafan server

![image](https://user-images.githubusercontent.com/67036413/111725463-1ad8eb80-8835-11eb-9ed4-b5212adb3a95.png)
