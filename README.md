# SoapService

WebService feito com .NET Core 3.1 utilizando a biblioteca [SoapCore](https://github.com/DigDes/SoapCore).  
Essa é apenas uma aplicação básica para fins de estudo e conhecimento da ferramenta.

> [Nuget SoapCore](https://www.nuget.org/packages/SoapCore/)

---

## Utilizando a aplicação

Rode utilizando o comando: `dotnet run`

Faça uma requisição POST para `http://localhost:5000/SoapService.asmx` , com o conteúdo em XML.

Corpo exemplo para requisição:

```xml
<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
   <soap:Header>
       <Header xmlns="http://soapservice.com.br/">
           <User>Lucas</User>
           <Password>S3nh@!</Password>
       </Header>
   </soap:Header>
   <soap:Body>
       <SoapServiceMethod xmlns="http://soapservice.com.br/">
           <Parameters>
               <Title>Teste</Title>
               <Code>123</Code>
               <Message>Essa é uma mensagem de teste</Message>
           </Parameters>
       </SoapServiceMethod>
   </soap:Body>
</soap:Envelope>
```

Resposta esperada para esse exemplo:

```xml
<?xml version="1.0" encoding="utf-8"?>
<s:Envelope xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">
   <s:Body>
       <SoapServiceMethodResponse xmlns="http://soapservice.com.br/">
           <SoapServiceMethodResult xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
               <User>Lucas</User>
               <Title>Teste</Title>
               <Code>123</Code>
               <Message>Essa é uma mensagem de teste</Message>
               <ResponseDateTime>2020-02-27T14:56:40.2588459Z</ResponseDateTime>
           </SoapServiceMethodResult>
       </SoapServiceMethodResponse>
   </s:Body>
</s:Envelope>
```
