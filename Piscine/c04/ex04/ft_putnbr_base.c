/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_putnbr_base.c                                   :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2020/11/05 11:52:20 by mfeijao           #+#    #+#             */
/*   Updated: 2020/11/05 11:56:48 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <unistd.h>

static void		ft_putchar(char c)
{
	write(1, &c, 1);
}

static int		ft_strlen(char *str)
{
	int		i;

	i = 0;
	while (str[i] != '\0')
		i++;
	return (i);
}

int				ft_base_is_valid(char *base)
{
	int		next_i;

	if (*base == 0 || *(base + 1) == 0)
		return (0);
	while (*base)
	{
		if (*base < 32 || *base == '+' || *base == '-')
			return (0);
		next_i = 1;
		while (*(base + next_i))
		{
			if (*base == *(base + next_i))
				return (0);
			next_i++;
		}
		base++;
	}
	return (1);
}

void			ft_putnbr_base(int nbr, char *base)
{
	unsigned int	count_b;
	unsigned int	p_nbr;

	if (ft_base_is_valid(base))
	{
		if (nbr < 0)
		{
			ft_putchar('-');
			p_nbr = (unsigned int)(-1 * nbr);
		}
		else
			p_nbr = (unsigned int)nbr;
		count_b = ft_strlen(base);
		if (p_nbr >= count_b)
		{
			ft_putnbr_base((p_nbr / count_b), base);
			ft_putnbr_base((p_nbr % count_b), base);
		}
		else
			write(1, &base[p_nbr], 1);
	}
}
