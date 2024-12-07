# Ponderada Semana 8

## Tutorial Passo a Passo
```
dotnet new web -o WebMetric
```
![image](https://github.com/user-attachments/assets/6cceb9c3-a644-46f5-b685-04079e4b30b1)


```
dotnet add package OpenTelemetry.Exporter.Prometheus.AspNetCore --prerelease
```

![image](https://github.com/user-attachments/assets/eccf33c0-c12c-4398-8ccc-209c34c7c703)


```
dotnet add package OpenTelemetry.Extensions.Hosting
```

![image](https://github.com/user-attachments/assets/05153184-717e-4a42-96df-17916aa40e85)


![image](https://github.com/user-attachments/assets/543c5724-f9d8-4460-b751-b3595ae50988)


```
dotnet tool update -g dotnet-counters
```

![image](https://github.com/user-attachments/assets/e33e9d2f-d599-4fa9-9a55-623841a4087a)


```
dotnet run
```

![image](https://github.com/user-attachments/assets/9f2fb86f-ee5b-43c0-a762-5db92b463ca2)


```
curl http://localhost:5190/
```
![image](https://github.com/user-attachments/assets/54b9234e-e896-48a7-a0fe-8fd56d29801a)


```
dotnet-counters monitor -n WebMetric --counters Microsoft.AspNetCore.Hosting
```
![image](https://github.com/user-attachments/assets/61953950-24a4-4ece-ad9f-0ad127e11d3d)


![image](https://github.com/user-attachments/assets/93ef7a6b-3e65-4f19-9639-aee1e011b482)

![image](https://github.com/user-attachments/assets/36ccd76e-5ab1-4916-83e7-375f809fdd4e)
