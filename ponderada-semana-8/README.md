# Ponderada Semana 8

Este repositório contém o código para a atividade da semana 8 do módulo 10, focado na coleta de métricas de um aplicativo ASP.NET Core, utilizando Prometheus para monitoramento e Grafana para visualização de métricas.

## Objetivo
O objetivo deste projeto é implementar um sistema para coletar métricas de um aplicativo ASP.NET Core e configurar o Prometheus para coleta dessas métricas. Além disso, o Grafana será configurado para exibir essas métricas por meio de gráficos interativos.

## Tecnologias Utilizadas

- **ASP.NET Core 8.0**: Framework utilizado para a aplicação backend.
- **Prometheus**: Sistema de monitoramento de métricas e coleta de dados.
- **Grafana**: Plataforma de visualização de métricas e criação de dashboards.

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


## Integração com Prometheus

Alteração no Código:

![image](https://github.com/user-attachments/assets/a0d63f3d-06a0-401f-b7b1-c2d3899a01d7)

Accessando rota de métricas:

![image](https://github.com/user-attachments/assets/71194eda-7c1f-4a90-9033-242fe58bbd53)

Garantindo que o prometheus enxerga a API:

![image](https://github.com/user-attachments/assets/f8e58ca7-66cf-442b-8cae-e1e2e3390ded)

Criando um gráfico simples para testar:

![image](https://github.com/user-attachments/assets/96c89729-12f7-4c20-a5f8-65b46db2ac3a)

Adicionando o grafana do docker-compose:

![image](https://github.com/user-attachments/assets/ce63cd00-8759-405a-bbe3-2c5b7dc9a423)


Iniciando o grafana:

![image](https://github.com/user-attachments/assets/9c178e46-9cb2-4e0c-a22f-48e8d5332dfd)

Criando uma nova conexão para http://prometheus:9090:

![image](https://github.com/user-attachments/assets/af17c270-df75-4f87-9823-921af9110cdc)

Criando um dashboard simples com os dados de métricas retirados do prometheus:

![image](https://github.com/user-attachments/assets/93e29f25-3938-4d54-b2f8-ce1ecd9b5333)





