#include <stdio.h>
#include <stdlib.h>
#include <math.h>


int ehPrimo(int numero){
	if (numero == 1)
		return 0; // 1 não é primo
	else if (numero < 4) 
		return 1; // 2 e 3 são primos
	else if (numero % 2 == 0)
		return 0; // Qualquer outro valor par não é primo
	else if (numero < 9)
		return 1; // Já está excluído 4, 6 e 8
	else if (numero % 3 == 0)
		return 0;
	else {
		int raiz = sqrt(numero);
		int divisor = 5;

		while (divisor <= raiz) {
			if (numero % divisor == 0)
				return 0;
			if (numero % (divisor + 2) == 0)
				return 0;

			divisor += 6;
		}
	}

	return 1;
}


int main() {
	int limite = 10001;
	int contador = 1; // sabemos que 2 é primo
	int candidato = 1;

	do {
		candidato += 2;
		if (ehPrimo(candidato))
			contador++;

	}while (contador != limite);
	
	printf("O primo 10001 é: %d \n", candidato);
	return 0;
}
