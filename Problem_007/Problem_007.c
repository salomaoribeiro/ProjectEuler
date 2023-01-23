#include<stdio.h>
#include<stdlib.h>

int main() {
	int quantidade = 2;
	int numeroPrimo = 0;

	for (int i = 3; quantidade <= 10001; i+=2) {
		int ehPrimo = 1;

		for (int j = 3; j < i; j+=2) {
			if ( i % j == 0) {
				ehPrimo = 0;
				break;
			}
		}

		if (ehPrimo) {
			quantidade++;
			numeroPrimo = i;
		}
	}
	
	printf("O primo 10001 é: %d \n", numeroPrimo);
}
