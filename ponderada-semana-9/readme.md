# Ponderada Semana 9


## Instalando Terraform

```
sudo apt-get update && sudo apt-get install -y gnupg software-properties-common
```

![image](https://github.com/user-attachments/assets/1cf707e8-b986-45e7-913e-38f25561920a)

```
wget -O- https://apt.releases.hashicorp.com/gpg | \
gpg --dearmor | \
sudo tee /usr/share/keyrings/hashicorp-archive-keyring.gpg > /dev/null
```

![image](https://github.com/user-attachments/assets/6378f402-8037-4f0d-b70b-3941e4b23a17)

```
gpg --no-default-keyring \
--keyring /usr/share/keyrings/hashicorp-archive-keyring.gpg \
--fingerprint
```
![image](https://github.com/user-attachments/assets/6832a335-a8c2-4d20-83df-982c934622c1)


```
echo "deb [signed-by=/usr/share/keyrings/hashicorp-archive-keyring.gpg] \
https://apt.releases.hashicorp.com $(lsb_release -cs) main" | \
sudo tee /etc/apt/sources.list.d/hashicorp.list
```

![image](https://github.com/user-attachments/assets/7f1fdd43-d96e-497a-80f3-86d5d7dbfe61)

```
sudo apt update
```

![image](https://github.com/user-attachments/assets/2af99343-fc3a-42c9-a497-4c57a0718fe3)


```
sudo apt-get install terraform
```

![image](https://github.com/user-attachments/assets/b9ab142b-9300-4a4f-88bf-0274827d0382)

```
terraform -help
```

![image](https://github.com/user-attachments/assets/c9915d92-28b6-440b-802d-a1f4faad6c2f)

## Criando configuração

Criando pasta do terraform:

![image](https://github.com/user-attachments/assets/1f2cb36d-c348-4478-8b6b-20ec293b72d8)

Criando arquivo main.tf:

![image](https://github.com/user-attachments/assets/7eab1764-58a4-4b6e-9c2c-475093848758)

## Executando Terraform

```
terraform init
```

![image](https://github.com/user-attachments/assets/ebe91cc0-5775-4acb-bed0-223a07338bf8)


```
terraform fmt
```

![image](https://github.com/user-attachments/assets/2dfa872d-008f-4954-9e0d-f7f15adf3864)

```
terraform validate
```

![image](https://github.com/user-attachments/assets/92e86bd7-81e1-4480-a267-a32f68e4bc81)

