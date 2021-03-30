# dependencia-entre-camadas
Projeto criado para estudo de dependência entre camadas.

# stack principal
- .NET Framework 4.7.2
- SQL Server

# dependências
| Camada | Dependências |
| ------ | ------------ |
| Dados | Nenhuma |
| Repositório | Dados, TO |
| TO | Nenhuma |
| Negócio | Repositório, TO |
| Testes | Negócio, TO |
| Serviço | Negócio, TO |
| Web | Serviço SOAP da camada de serviço |

		
