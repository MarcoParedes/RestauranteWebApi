¨

bD:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Entities\Models\ComentarioModel.cs
	namespace 	
Restaurante
 
. 
Entities 
. 
Models %
{ 
public 

class 
ComentarioModel  
{ 
public 
int 
idComentario 
{  !
get" %
;% &
set' *
;* +
}, -
public 
short 
? 
puntaje 
{ 
get  #
;# $
set% (
;( )
}* +
public		 
string		 

comentario		  
{		! "
get		# &
;		& '
set		( +
;		+ ,
}		- .
public

 
UsuarioModel

 
usuario

 #
{

$ %
get

& )
;

) *
set

+ .
;

. /
}

0 1
public 
DateTime 
? 
fecha 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
int 
? 
idPlato 
{ 
get !
;! "
set# &
;& '
}( )
} 
} ˇ
dD:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Entities\Models\DetallePlatoModel.cs
	namespace 	
Restaurante
 
. 
Entities 
. 
Models %
{ 
public 

class 
DetallePlatoModel "
{ 
public 

PlatoModel 
plato 
{  !
get" %
;% &
set' *
;* +
}, -
public 
DetallePlatoModel  
(  !
)! "
{# $
this 
. 
plato 
= 
new 

PlatoModel '
(' (
)( )
;) *
} 	
} 
} Ÿ
]D:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Entities\Models\PlatoModel.cs
	namespace 	
Restaurante
 
. 
Entities 
. 
Models %
{ 
public 

class 

PlatoModel 
{ 
public		 
int		 
id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
public

 
string

 
nombre

 
{

 
get

 "
;

" #
set

$ '
;

' (
}

) *
public 
string 
descripcion !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
decimal 
? 
precio 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
TipoPlatoModel 
	tipoPlato '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
string 
imagen 
{ 
get "
;" #
set$ '
;' (
}) *
public 
List 
< 
ComentarioModel #
># $
comentarios% 0
{1 2
get3 6
;6 7
set8 ;
;; <
}= >
} 
} ’
aD:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Entities\Models\TipoPlatoModel.cs
	namespace 	
Restaurante
 
. 
Entities 
. 
Models %
{ 
public 

class 
TipoPlatoModel 
{ 
public 
int 
id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
descripcion !
{" #
get$ '
;' (
set) ,
;, -
}. /
public		 
string		 
imagen		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
public

 
bool

 
estado

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
public 
TipoPlatoModel 
( 
) 
{ 	
this 
. 
id 
= 
$num 
; 
this 
. 
descripcion 
= 
string %
.% &
Empty& +
;+ ,
this 
. 
imagen 
= 
string  
.  !
Empty! &
;& '
this 
. 
estado 
= 
false 
;  
} 	
public 
TipoPlatoModel 
( 
int !
id" $
,$ %
string& ,
descripcion- 8
,8 9
string: @
imagenA G
,G H
boolI M
estadoN T
)T U
{ 	
this 
. 
id 
= 
id 
; 
this 
. 
descripcion 
= 
descripcion *
;* +
this 
. 
imagen 
= 
imagen  
;  !
this 
. 
estado 
= 
estado  
;  !
} 	
} 
} ã
_D:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Entities\Models\UsuarioModel.cs
	namespace 	
Restaurante
 
. 
Entities 
. 
Models %
{ 
public 

class 
UsuarioModel 
{ 
public		 
int		 
id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
public

 
string

 
correo

 
{

 
get

 "
;

" #
set

$ '
;

' (
}

) *
public 
string 
clave 
{ 
get !
;! "
set# &
;& '
}( )
public 
int 
edad 
{ 
get 
; 
set "
;" #
}$ %
public 
string 
nombreCompleto $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
UsuarioModel 
( 
) 
{ 	
this 
. 
id 
= 
$num 
; 
this 
. 
correo 
= 
string  
.  !
Empty! &
;& '
this 
. 
clave 
= 
string 
.  
Empty  %
;% &
this 
. 
edad 
= 
$num 
; 
this 
. 
nombreCompleto 
=  !
string" (
.( )
Empty) .
;. /
} 	
public 
UsuarioModel 
( 
int 
id  "
," #
string$ *
correo+ 1
,1 2
string3 9
clave: ?
,? @
intA D
edadE I
,I J
stringK Q
nombreCompletoR `
)` a
{ 	
this 
. 
id 
= 
id 
; 
this 
. 
correo 
= 
correo  
;  !
this 
. 
clave 
= 
clave 
; 
this 
. 
edad 
= 
edad 
; 
this 
. 
nombreCompleto 
=  !
nombreCompleto" 0
;0 1
} 	
}!! 
}"" ⁄
fD:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Entities\ObtenerDetallePlatoRequest.cs
	namespace 	
Restaurante
 
. 
Entities 
{ 
public 

class &
ObtenerDetallePlatoRequest +
{ 
public 
int 
idPlato 
{ 
get  
;  !
set" %
;% &
}' (
} 
}		 è
gD:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Entities\ObtenerDetallePlatoResponse.cs
	namespace 	
Restaurante
 
. 
Entities 
{ 
public 

class '
ObtenerDetallePlatoResponse ,
{ 
public		 
DetallePlatoModel		  
detallePlato		! -
{		. /
get		0 3
;		3 4
set		5 8
;		8 9
}		: ;
public '
ObtenerDetallePlatoResponse *
(* +
)+ ,
{ 	
this 
. 
detallePlato 
= 
new  #
DetallePlatoModel$ 5
(5 6
)6 7
;7 8
} 	
} 
} “
`D:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Entities\ObtenerPlatosRequest.cs
	namespace 	
Restaurante
 
. 
Entities 
{ 
public 

class  
ObtenerPlatosRequest %
{ 
public 
int 
idTipoPlato 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
}		 ä
aD:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Entities\ObtenerPlatosResponse.cs
	namespace 	
Restaurante
 
. 
Entities 
{ 
public 

class !
ObtenerPlatosResponse &
{ 
public		 
List		 
<		 

PlatoModel		 
>		 

platosList		  *
{		+ ,
get		- 0
;		0 1
set		2 5
;		5 6
}		7 8
}

 
} â
]D:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Entities\TipoPlatoResponse.cs
	namespace 	
Restaurante
 
. 
Entities 
{ 
public 

class 
TipoPlatoResponse "
{ 
public		 
List		 
<		 
TipoPlatoModel		 #
>		# $
TipoPlatoList		% 2
{		3 4
get		5 8
;		8 9
set		: =
;		= >
}		? @
}

 
} √	
ZD:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Entities\UsuarioRequest.cs
	namespace 	
Restaurante
 
. 
Entities 
{ 
public 

class 
UsuarioRequest 
{ 
public 
int 
id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
correo 
{ 
get "
;" #
set$ '
;' (
}) *
public		 
string		 
clave		 
{		 
get		 !
;		! "
set		# &
;		& '
}		( )
public

 
string

 
nombreCompleto

 $
{

% &
get

' *
;

* +
set

, /
;

/ 0
}

1 2
public 
string 
telefono 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
int 
edad 
{ 
get 
; 
set "
;" #
}$ %
} 
} é
cD:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Entities\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str /
)/ 0
]0 1
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
$str 1
)1 2
]2 3
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
]$$) *Ë
[D:\Proyectos\RestauranteWebApi\Restaurante.Solution\Restaurante.Entities\UsuarioResponse.cs
	namespace 	
Restaurante
 
. 
Entities 
{ 
public 

class 
UsuarioResponse  
{ 
public 
string 
correo 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
nombreCompleto $
{% &
get' *
;* +
set, /
;/ 0
}1 2
}		 
}

 