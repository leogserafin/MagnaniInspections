## Sistema para empresa de inspeções em postes de energia elétrica
```
região: itajaí

realizar inspeções mensalmente (todos os postes)
```
### Útil para o bd
```
INSPEÇÃO
	-ID(PK)
	-data
	-estado do poste (estado de conservação adequado ou nao)
	-poste prumo (se ta reto ou não)
	-condição da fiação (adequado ou nao)

POSTE
	-etiqueta (isso q usa para saber qual poste está avaliando)(id digitado na hora do cadastro)(PK)
	-altura do poste
	-material construido (ferro ou concreto)
	-coordenada geografica do poste (latitude e longitude)
	-qual caixa alimenta

quais sao as caixas de distribuição q alimentam cada poste

CAIXA (caixas/ponto de distribuição)
	-etiqueta (PK)
	-tipo (caixa exposta ou subterranea)
	-capacidade de alimentação (quantos Watts essa caixa alimenta)
	-coordenada geografica do poste (latitude e longitude)
```

todo poste deve ter pelo menos 1 inspeção por mes
precisa mostrar quais postes nao foram inspecionados no mes!!
desde q sejam em meses distintos não há problema 
(impossivel haver 2 inspeções no mesmo mes do mesmo poste!!!)

### Tipos de relatórios e como devem ser tratados
```
relatorio de postes nao inspecionados por mes
-quais postes nao tiveram inspeção pela data descrita pelo usuario (data inicial e final)(mes/ano)

relatorio numero de postes por condição por mes
-numero de postes por condição (em janeiro 20 postes adequados e 10 postes inadequados)
EX.:
```
| MES | ADEQ | NAO ADEQ |
|--|--|--|
| JAN | 2 | 5 |
| FEV | 3 | 6 |
```
relatorio saude das caixas por periodo
quantos problemas foram relatados por caixa em um determiado período
cada poste pode conter até 3 problemas (poste prumo, adquação e fiação)
usuario fala data
EX.:
```
|CAIXA | PROBLEMAS | MAX PROBLEMAS | 
|--|--|--|
| 1 | 1 | (n de postesx3xmes) | 
| 2 | 25 | (n de postesx3xmes) | 
| 3 | 112 | (n de postesx3xmes) | 


### Interface
```
menu - cadastro de postes (id digitado sem serial)(excluir se necessario)
 - relatórios - cadastro de inspeção - cadastro de caixa 

lista de postes > cadastro e exclusão de postes
lista de caixas > cadastro e exclusão de caixas
lista de inspeções > cadastro e exclusão de inspeções

excluir poste exclui inspeções (verifica uma lista de inspeções e exclui todas as inpeções dessa lista)

insere ou exclui inspeção. Não edita 

nao precisara de login
menu principal = menu de opções
```
