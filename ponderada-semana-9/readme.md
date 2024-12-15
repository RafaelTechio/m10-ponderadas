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
