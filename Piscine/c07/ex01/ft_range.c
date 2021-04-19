/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_range.c                                         :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2020/11/07 16:42:30 by mfeijao           #+#    #+#             */
/*   Updated: 2020/11/09 12:50:09 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>

int		*ft_range(int min, int max)
{
	int		range;
	int		i;
	int		*tab;

	i = max - min - 1;
	if (min >= max)
		return (0);
	if ((tab = malloc(i * sizeof(int))) == 0)
		return (0);
	range = 0;
	while (range <= i)
	{
		tab[range] = min + range;
		range++;
	}
	return (tab);
}
