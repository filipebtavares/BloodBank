# 🩸 BloodBank API

Este é um projeto que desenvolvi com muito carinho e vontade de aprender, chamado **BloodBank API**. A ideia aqui é simples, mas poderosa: gerenciar doações de sangue de forma organizada, limpa e escalável.

---

## 🚀 Por trás da cortina: Tecnologias e padrões utilizados

Esse projeto não é só uma API qualquer. Ele foi pensado desde o início com boas práticas e padrões modernos para que seja **fácil de manter**, **escalável** e **realista** com o que o mercado pede.

🔧 Tecnologias e conceitos utilizados:

- ✅ **Arquitetura Limpa (Clean Architecture)** — Separação clara das responsabilidades.
- 📚 **Padrão CQRS** — Comandos e consultas separados, o que ajuda a manter o código mais organizado e **facilita a evolução** do sistema.  
  > *Estudos mostram que usar CQRS pode aumentar a produtividade e clareza do time em até 30% em projetos com regras de negócio mais complexas.*
- 📦 **Padrão Repository** — Acesso à base de dados de forma desacoplada.
- 🔍 **Validações com FluentValidation** — Validação limpa e desacoplada dos models.
- 🌐 **Consumo de API externa (ViaCEP)** — Consulta de CEPs utilizando a biblioteca RestSharp.
- 🐳 **Container Docker** — Permite rodar essa aplicação em qualquer ambiente, sem "e se faltar tal dependência?".

---

## 🖥️ Como rodar o projeto na sua máquina

Você pode rodar o projeto de duas formas: via Docker (recomendado, super prático) ou manualmente com .NET.

### 🔁 Opção 1: Rodando com Docker (mais rápido e limpo)

**Pré-requisitos**: [Docker instalado](https://www.docker.com/products/docker-desktop/)

# Puxe a imagem da API (copiar)
docker pull filipebeniciodev/bloodbank-api:latest

# Rode o container mapeando a porta local 7030 para a porta do container 8080
docker run -d -p 7030:8080 filipebeniciodev/bloodbank-api:latest

### 💻 Opção 2: Rodando localmente com o .NET
# .NET SDK 8 ou superior instalado
# Clone o repositório
git clone https://github.com/seu-usuario/bloodbank.git
cd bloodbank

# Vá para o projeto da API
cd BloodBank.API

# Rode o projeto
dotnet run



# Algumas Imagens:
![Inserir um título](https://github.com/user-attachments/assets/86aaec5f-4b0b-416e-9e95-2e41cb9855dc)
![swager postagem](https://github.com/user-attachments/assets/41843233-101c-426a-8e60-4862ab9be3f2)
