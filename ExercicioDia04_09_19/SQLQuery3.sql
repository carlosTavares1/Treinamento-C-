insert into Funcionarios (Nome) values
('Felipe'),('Giomar')
GO
insert into Produtos(Nome,Valor) values
('Skol beats',5.49),
('Budweiser 550ml',6.99),
('Stella Artois',5.49),
('Patagonia',15.90),
('Corona',4.99)
GO
select * from Funcionarios
select * from Produtos
--insert na tabela de pedidos
INSERT INTO Pedidos(Funcionario,Produto,Quantidade) VALUES
(1,4,2),
(1,3,5),
(2,2,4)
--Seleção em ordem alfabetica
select * from Funcionarios order by Nome
--seleção do mais caro para o mais barato
select * from Produtos order by Valor desc
--seleção de pedidos por funcionarios
select ped.Id,fun.Nome,ped.Produto,ped.Quantidade 
from Funcionarios fun inner join Pedidos ped
on fun.Id = ped.Funcionario
--
select fun.Nome,SUM(ped.Quantidade) as 'Total' 
from Pedidos ped 
inner join Funcionarios fun
on ped.Funcionario = fun.Id GROUP BY fun.Nome
--
SELECT fun.Nome,SUM(pro.Valor*ped.Quantidade) as 'Total'
FROM Funcionarios fun inner join Pedidos ped
on fun.Id = ped.Funcionario inner join Produtos pro
on ped.Produto = pro.Id group by fun.Nome
--
select top 1 pro.Nome,sum(ped.Quantidade) as 'Quantidade'
from Produtos pro inner join Pedidos ped
on pro.Id = ped.Produto
group by pro.Nome
order by sum(ped.Quantidade) desc
--
select top 1 pro.Nome,sum(pro.Valor*ped.Quantidade) as 'Total'
from Produtos pro inner join Pedidos ped
on pro.Id = ped.Produto group by pro.Nome
order by Total desc
--
select * from Produtos where Id not in 
(
select ped.Produto from Funcionarios fun inner join Pedidos ped
on fun.Id = ped.Funcionario 
where fun.Nome like 'Felipe%')

select * from Produtos pro left join Pedidos ped
on pro.Id = ped.Produto
where ped.Produto is null

select pro.Nome,count(ped.Produto) as 'Pedidos' 
from Produtos pro left join Pedidos ped 
on pro.Id = ped.Produto group by pro.Nome
order by Pedidos desc