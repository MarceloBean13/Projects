/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_memcpy.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 16:07:05 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 16:08:06 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <string.h>

void	*ft_memcpy(void *dest, const void *src, size_t size)
{
	unsigned char	*tempdest;
	unsigned char	*tempsrc;
	size_t			i;

	i = 0;
	tempdest = (unsigned char *)dest;
	tempsrc = (unsigned char *)src;
	if (!src && !dest)
		return (dest);
	while (size)
	{
		*tempdest = *tempsrc;
		size--;
		tempdest++;
		tempsrc++;
	}
	return (dest);
}
