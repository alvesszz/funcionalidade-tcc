create table Usuario (
							Cpf numeric(11)constraint Cpf_Cad_pk primary key,
							id numeric(11)  null,
							senha varchar(40) null,
							nome varchar (40) null ,
							email varchar(40) null

                      )

select * from Usuario
