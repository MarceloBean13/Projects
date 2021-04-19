/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_find_next_prime.c                               :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2020/11/04 09:27:18 by mfeijao           #+#    #+#             */
/*   Updated: 2020/11/05 16:36:56 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

int		isprime(int n)
{
	int i;

	i = 2;
	if (n == 0 || n == 1 || n < 0)
		return (0);
	while (i <= n / i)
	{
		if (n % i == 0)
			return (0);
		i++;
	}
	return (1);
}

int		ft_find_next_prime(int nb)
{
	long int a;

	a = 1;
	if (isprime(nb))
		return (nb);
	while (!isprime(nb + a))
		a++;
	return (nb + a);
}
