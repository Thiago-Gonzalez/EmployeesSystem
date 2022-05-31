# EmployeesSystem
<p>Simples sistema de cadastro de funcionários para prática do conceito de polimorfismo em OO.</p>
<p>Neste projeto, é criada são criadas duas classes Employee e OutsourcedEmployee, a primeira contendo os atributos Name, Hours e ValuePerHour, e a segunda, que é uma subclasse de Employee, contém um atributo adicional AdditionalCharge.</p>
<p>Por herança, ambas as classes implementam um método Payment, que retorna um double, sendo o produto entre Hours e ValuePerHour, mas, no entanto, para a classe OutsourcedEmployee, ela deve ser implementada de forma diferente, com o adicional de 110% do AdditionalCharge, necessitanto o método ser sobreposto.</p>
<p>Dessa forma, na classe principal é realizado o cadastro de N funcionários (uma lista do tipo Employee), podendo ser adicionados tanto Employees quanto OutsourcedEmployees, cada qual tendo seus dados preenchidos de acordo com o tipo do objeto. Por fim, ao final do programa, são exibidos os valores de pagamento para cada funcionário.</p>
<p>O conceito de Polimorfismo é caracterizado por variáveis do mesmo tipo mais genérico (Employee) possam apontar para objetos de tipos distintos (Employee e OutsourcedEmployee), tendo assim, comportamentos diferentes conforme cada tipo específico. Tal, conceito foi possível ser visto no exemplo de execução abaixo, em que o funcionário Bob teve seu valor de pagamento calculado por uma lógica diferente da dos demais.</p>

![image](https://user-images.githubusercontent.com/80121288/171071826-ac748fd5-0277-46e2-83c2-68ac7a9d5573.png)
