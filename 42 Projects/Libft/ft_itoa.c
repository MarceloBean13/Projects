/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_itoa.c                                          :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:32:03 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 15:33:19 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void	ft_neg(int *n, int *y)
{
	if (*n < 0)
	{
		*n *= -1;
		*y = 1;
	}
}

char	*ft_itoa(int n)
{
	int		i;
	int		x;
	int		y;
	char	*temp;

	if (n == -2147483648)
		return (ft_strdup("-2147483648"));
	i = n;
	x = 2;
	y = 0;
	ft_neg(&n, &y);
	while (i /= 10)
		x++;
	x += y;
	if ((temp = (char *)malloc(sizeof(char) * x)) == NULL)
		return (NULL);
	temp[--x] = '\0';
	while (x--)
	{
		temp[x] = n % 10 + '0';
		n = n / 10;
	}
	if (y)
		temp[0] = '-';
	return (temp);
}
