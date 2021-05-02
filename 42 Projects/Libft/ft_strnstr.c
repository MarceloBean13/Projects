/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strnstr.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:56:11 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 15:57:19 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <string.h>

char	*ft_strnstr(const char *hay, const char *ned, size_t size)
{
	size_t	x;
	size_t	y;

	x = 0;
	y = 0;
	if (!*ned)
		return ((char *)hay);
	while (hay[x] != '\0' && x < size)
	{
		if (hay[x] == ned[0])
		{
			while (ned[y] && hay[x + y] == ned[y] && x + y < size)
			{
				if (ned[y + 1] == '\0')
					return ((char *)&hay[x]);
				y++;
			}
		}
		x++;
	}
	return (NULL);
}
