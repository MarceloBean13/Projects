/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_ultimate_range.c                                :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2020/11/08 14:29:14 by mfeijao           #+#    #+#             */
/*   Updated: 2020/11/10 11:50:00 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>

int		ft_ultimate_range(int **range, int min, int max)
{
	int	diff;
	int	i;
	int	*temp;

	if (min >= max)
	{
		*range = 0;
		return (0);
	}
	diff = max - min - 1;
	if ((temp = malloc(diff * sizeof(int))) == NULL)
	{
		*range = 0;
		return (-1);
	}
	*range = temp;
	i = 0;
	while (i <= diff)
	{
		temp[i] = min + i;
		i++;
	}
	return (diff + 1);
}
