/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_print_comb2.c                                   :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2020/10/26 11:32:20 by mfeijao           #+#    #+#             */
/*   Updated: 2020/10/27 17:23:16 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <unistd.h>

void	put_char(char c)
{
	write(1, &c, 1);
}

void	ft_print_comb2(void)
{
	char a;
	char b;

	a = 0;
	while (a <= 98)
	{
		b = a + 1;
		while (b <= 99)
		{
			put_char((a / 10) + '0');
			put_char((a % 10) + '0');
			write(1, " ", 1);
			put_char((b / 10) + '0');
			put_char((b % 10) + '0');
			if (a == 98 && b == 99)
				;
			else
				write(1, ", ", 2);
			b++;
		}
		a++;
	}
}
