Ô
SD:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Logic\IPlatosBiz.cs
	namespace 	
Restaurante
 
. 
Logic 
{ 
public 

	interface 

IPlatosBiz 
{ !
ObtenerPlatosResponse 
ObtenerPlatoPorTipo 1
(1 2
int2 5
idTipoPlato6 A
)A B
;B C'
ObtenerDetallePlatoResponse		 #
ObtenerDetallePlato		$ 7
(		7 8&
ObtenerDetallePlatoRequest		8 R
request		S Z
)		Z [
;		[ \
}

 
} ê
VD:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Logic\ITipoPlatoBiz.cs
	namespace 	
Restaurante
 
. 
Logic 
{ 
public 

	interface 
ITipoPlatoBiz "
{ 
TipoPlatoResponse 
ObtenerTipoPlato *
(* +
)+ ,
;, -
}		 
}

 ¡
TD:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Logic\IUsuarioBiz.cs
	namespace 	
Restaurante
 
. 
Logic 
{ 
public 

	interface 
IUsuarioBiz  
{ 
UsuarioResponse		 
RegistrarUsuario		 (
(		( )
UsuarioRequest		) 7
request		8 ?
)		? @
;		@ A
bool

 
Ingresar

 
(

 
UsuarioRequest

 $
request

% ,
)

, -
;

- .
} 
} ã
`D:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Logic\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str ,
), -
]- .
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str .
). /
]/ 0
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *