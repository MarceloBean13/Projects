/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_is_prime.c                                      :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2020/11/03 14:43:07 by mfeijao           #+#    #+#             */
/*   Updated: 2020/11/05 18:58:35 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

int		ft_is_prime(int n)
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
