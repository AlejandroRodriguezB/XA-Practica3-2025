# XA-Practica3-2025
El objetivo de esta práctica es desplegar nuestra aplicación desplegada en las prácticas anteriores junto con la base de datos PostgreSQL, Redis y los servicios de monitorización en un clúster de Kubernetes. Se deberá crear un pipeline de CI/CD con Github Actions para simular el despliegue continuo

# Testing

kubectl port-forward -n monitoring svc/prometheus-server 9090:80

http://localhost:9090/query 

kubectl port-forward svc/minio 9001:9001 -n dev/pro

http://localhost:9001
