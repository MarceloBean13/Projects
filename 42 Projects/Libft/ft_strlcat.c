/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strlcat.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:50:27 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 15:51:04 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

size_t	ft_strlcat(char *dest, const char *src, size_t size)
{
	size_t x;
	size_t y;

	x = 0;
	while (dest[x] != '\0' && x < size)
		x++;
	y = x;
	while (src[x - y] && x + 1 < size)
	{
		dest[x] = src[x - y];
		x++;
	}
	if (x < size)
		dest[x] = '\0';
	return (y + ft_strlen(src));
}
