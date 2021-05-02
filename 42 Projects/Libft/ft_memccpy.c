/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_memccpy.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:33:41 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 15:35:35 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <string.h>

void	*ft_memccpy(void *dest, const void *src, int c, size_t size)
{
	size_t			i;
	unsigned char	*tempdest;
	unsigned char	*tempsrc;

	i = 0;
	tempdest = (unsigned char *)dest;
	tempsrc = (unsigned char *)src;
	if (!src && !dest)
		return (dest);
	while (size--)
	{
		tempdest[i] = tempsrc[i];
		if (tempsrc[i] == (unsigned char)c)
			return (dest + i + 1);
		i++;
	}
	return (NULL);
}
