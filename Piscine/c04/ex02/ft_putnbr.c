/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_putnbr.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2020/11/01 18:46:26 by mfeijao           #+#    #+#             */
/*   Updated: 2020/11/05 12:02:35 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <unistd.h>

void	putchar(char c)
{
	write(1, &c, 1);
}

void	ft_putnbr(int nb)
{
	long int n;

	n = nb;
	if (nb < 0)
	{
		putchar('-');
		n = -n;
	}
	if (n / 10)
		ft_putnbr(n / 10);
	putchar(n % 10 + '0');
}
