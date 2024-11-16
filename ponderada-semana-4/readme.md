# Ponderada Semana 4

Rafael Mateus Zimmer Techio

Passos do tutorial da ponderada:

1. Criando Aplicação

```
dotnet new console
```
![image](https://github.com/user-attachments/assets/211ebc40-1861-48d9-8f31-2aacd29295b1)

![image](https://github.com/user-attachments/assets/cd504e29-80a4-4879-92c5-881bb1c24312)

2. Adicionando pacotes de diagnóstico

```
dotnet add package System.Diagnostics.DiagnosticSource
```
![image](https://github.com/user-attachments/assets/63692122-28d0-4241-9b60-c5323edde1bf)


![image](https://github.com/user-attachments/assets/764d9ff6-528e-46e6-871b-7d97284f8b0f)

![image](https://github.com/user-attachments/assets/b4505ef6-c713-4d78-b284-eacfe103dfe5)

```
dotnet tool update -g dotnet-counters
```
![image](https://github.com/user-attachments/assets/fa44dd2e-900f-4a80-8439-f16a5e9b366b)

3. Monitorando aplicação

```
dotnet-counters monitor -n ponderada-semana-4  --counters HatCo.Store
```

![image](https://github.com/user-attachments/assets/bd7a244f-f941-4c2c-9927-c417366faed9)

![image](https://github.com/user-attachments/assets/cfd421ef-0146-4955-9646-afb55fda34fa)


Após alterar o projeto:

![image](https://github.com/user-attachments/assets/a413acb4-94a2-4eda-b2aa-d3b41f542c7a)

4. Adicionando mais métricas

Algumas adaptações foram necessárias para o código do tutorial funcionar: 

![image](https://github.com/user-attachments/assets/744e5111-f5dc-4eca-8c9b-56bd74f5a0c1)

```
dotnet-counters monitor -n ponderada-semana-4  --counters HatCo.Store
```

![image](https://github.com/user-attachments/assets/87889b25-99cb-4ff4-becc-94e5fb13019c)

5. Descrições e Unidades

![image](https://github.com/user-attachments/assets/b29cbe67-79db-43a3-9dea-0004b2b146ae)

```
dotnet-counters monitor -n ponderada-semana-4  --counters HatCo.Store
```

![image](https://github.com/user-attachments/assets/e82e45a8-e81a-48ff-b539-cb9eb267de41)

6. Métricas Multidimensionais

![image](https://github.com/user-attachments/assets/8bbe791a-39bc-4d47-a02b-5cbab95da234)

```
dotnet-counters monitor -n ponderada-semana-4  --counters HatCo.Store
```

![image](https://github.com/user-attachments/assets/f8f05593-4ec2-4f8e-99a5-1c6eac84c62b)

![image](https://github.com/user-attachments/assets/c76656b5-95a9-49b6-976c-4eb51708d700)
